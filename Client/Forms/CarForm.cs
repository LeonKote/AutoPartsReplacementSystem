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

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Необходимо заполнить марку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox2.Text == "")
			{
				MessageBox.Show("Необходимо заполнить модель", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox3.Text == "")
			{
				MessageBox.Show("Необходимо заполнить год выпуска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!int.TryParse(textBox3.Text, out int year) || year < 0)
			{
				MessageBox.Show("Год выпуска некорректен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			AddCarRequest = new AddCarRequest()
			{
				Make = textBox1.Text,
				Model = textBox2.Text,
				Year = year
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
