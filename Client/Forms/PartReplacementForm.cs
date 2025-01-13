using Api.Modules.PartReplacement.Dto;
using Domain.Models;

namespace Client.Forms
{
	public partial class PartReplacementForm : Form
	{
		private readonly List<Part> parts;

		public AddPartReplacementRequest? AddPartReplacementRequest { get; private set; }

		public PartReplacementForm(List<Part> parts, int idx)
		{
			InitializeComponent();
			this.parts = parts;
			partComboBox.Items.AddRange(parts.Select(x => x.Name).ToArray());
			partComboBox.SelectedIndex = idx > -1 ? idx + 1 : 0;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			if (!ValidateInputs())
				return;

			int index = partComboBox.SelectedIndex - 1;
			AddPartReplacementRequest = new AddPartReplacementRequest()
			{
				PartId = parts[index].Id,
				Date = DateOnly.FromDateTime(dateDateTimePicker.Value)
			};

			DialogResult = DialogResult.OK;
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private bool ValidateInputs()
		{
			int index = partComboBox.SelectedIndex - 1;
			if (index == -1)
				return ShowError("Необходимо выбрать деталь");

			return true;
		}

		private bool ShowError(string message)
		{
			MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
	}
}
