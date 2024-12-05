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

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Необходимо заполнить название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox2.Text == "")
			{
				MessageBox.Show("Необходимо заполнить описание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			AddPartRequest = new AddPartRequest()
			{
				Name = textBox1.Text,
				Description = textBox2.Text
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
