using Api.Modules.PartReplacement.Dto;
using Domain.Models;

namespace Client.Forms
{
	public partial class PartReplacementForm : Form
	{
		private readonly List<Part> parts;

		public AddPartReplacementRequest? AddPartReplacementRequest { get; private set; }

		public PartReplacementForm(List<Part> parts)
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;
			this.parts = parts;
			comboBox1.Items.AddRange(parts.Select(x => x.Name).ToArray());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int index = comboBox1.SelectedIndex - 1;
			if (index == -1)
			{
				MessageBox.Show("Необходимо выбрать деталь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			AddPartReplacementRequest = new AddPartReplacementRequest()
			{
				PartId = parts[index].Id,
				Date = DateOnly.FromDateTime(dateTimePicker1.Value)
			};
			DialogResult = DialogResult.OK;
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
