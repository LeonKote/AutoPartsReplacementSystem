using Api.Modules.Car.Dto;

namespace Client.Forms
{
	public partial class CarForm : Form
	{
		public AddCarRequest? AddCarRequest { get; private set; }

		public CarForm()
		{
			InitializeComponent();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			if (!ValidateInputs())
				return;

			AddCarRequest = new AddCarRequest()
			{
				Make = makeTextBox.Text.Trim(),
				Model = modelTextBox.Text.Trim(),
				Year = int.Parse(yearTextBox.Text.Trim())
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
			if (string.IsNullOrWhiteSpace(makeTextBox.Text))
				return ShowError("Необходимо заполнить марку");

			if (string.IsNullOrWhiteSpace(modelTextBox.Text))
				return ShowError("Необходимо заполнить модель");

			if (string.IsNullOrWhiteSpace(yearTextBox.Text) || !int.TryParse(yearTextBox.Text, out int year) || year < 0)
				return ShowError("Год выпуска некорректен");

			return true;
		}

		private bool ShowError(string message)
		{
			MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
	}
}
