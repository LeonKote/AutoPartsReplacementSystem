using Api.Modules.Part.Dto;

namespace Client.Forms
{
	public partial class PartForm : Form
	{
		public AddPartRequest? AddPartRequest { get; private set; }

		public PartForm()
		{
			InitializeComponent();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			if (!ValidateInputs())
				return;

			AddPartRequest = new AddPartRequest
			{
				Name = nameTextBox.Text.Trim(),
				Description = descriptionTextBox.Text.Trim()
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
			if (string.IsNullOrWhiteSpace(nameTextBox.Text))
				return ShowError("Необходимо заполнить название");

			if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
				return ShowError("Необходимо заполнить описание");

			return true;
		}

		private bool ShowError(string message)
		{
			MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
	}
}
