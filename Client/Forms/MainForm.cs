using Api.Modules.Car.Dto;
using Domain.Models;

namespace Client.Forms
{
	public partial class MainForm : Form
	{
		private readonly ApiClient client;

		private List<Car> cars = null!;
		private List<Part> parts = null!;
		private List<PartReplacement> partReplacements = null!;

		public MainForm()
		{
			InitializeComponent();
			client = new ApiClient("https://wizzasd.ru:7281");
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			await UpdateCarList();
			await UpdatePartsList();
		}

		#region Cars

		private async void button1_Click(object sender, EventArgs e)
		{
			using var form = new CarForm();
			if (form.ShowDialog() == DialogResult.Cancel)
				return;

			await client.AddCarAsync(form.AddCarRequest!);
			await UpdateCarList();
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			var car = cars[index];
			await client.DeleteCarAsync(car.Id);
			await UpdateCarList();
		}

		private async Task UpdateCarList()
		{
			button2.Enabled = false;
			var cars = await client.GetCarsAsync(new GetCarsRequest());
			if (cars == null)
			{
				MessageBox.Show("Не удалось получить список автомобилей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.cars = cars;
			listBox1.Items.Clear();
			listBox1.Items.AddRange(cars.Select(x => $"{x.Make} {x.Model} {x.Year}").ToArray());
		}

		private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			var car = cars[index];
			button2.Enabled = true;
			await UpdatePartReplacementsList(car.Id);
		}

		private void listBox1_DoubleClick(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			if (index == -1)
				return;

			var car = cars[index];
			MessageBox.Show($"Марка: {car.Make}\n" +
							$"Модель: {car.Model}\n" +
							$"Год выпуска: {car.Year}", "Данные об автомобиле");
		}

		#endregion

		#region PartReplacements

		private async void button3_Click(object sender, EventArgs e)
		{
			using var form = new PartReplacementForm(parts);
			if (form.ShowDialog() == DialogResult.Cancel)
				return;

			int index = listBox1.SelectedIndex;
			var car = cars[index];
			form.AddPartReplacementRequest!.CarId = car.Id;
			await client.AddPartReplacementAsync(form.AddPartReplacementRequest!);
			await UpdatePartReplacementsList(car.Id);
		}

		private async void button4_Click(object sender, EventArgs e)
		{
			int carIndex = listBox1.SelectedIndex;
			int partIndex = listBox2.SelectedIndex;
			var car = cars[carIndex];
			var part = partReplacements[partIndex];
			await client.DeletePartReplacementAsync(part.Id);
			await UpdatePartReplacementsList(car.Id);
		}

		private async Task UpdatePartReplacementsList(Guid carId)
		{
			button4.Enabled = false;
			var partReplacements = await client.GetPartReplacementsAsync(carId);
			if (partReplacements == null)
			{
				MessageBox.Show("Не удалось получить список замененных деталей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.partReplacements = partReplacements;
			listBox2.Items.Clear();
			listBox2.Items.AddRange(partReplacements.Select(x => x.Part.Name).ToArray());
			button3.Enabled = true;
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			button4.Enabled = true;
		}

		private void listBox2_DoubleClick(object sender, EventArgs e)
		{
			int index = listBox2.SelectedIndex;
			if (index == -1)
				return;

			var partReplacement = partReplacements[index];
			MessageBox.Show($"Название: {partReplacement.Part.Name}\n" +
							$"Описание: {partReplacement.Part.Description}\n" +
							$"Дата замены: {partReplacement.Date}", "Данные о замененной детали");
		}

		#endregion

		#region Parts

		private async void button5_Click(object sender, EventArgs e)
		{
			using var form = new PartForm();
			if (form.ShowDialog() == DialogResult.Cancel)
				return;

			await client.AddPartAsync(form.AddPartRequest!);
			await UpdatePartsList();
		}

		private async void button6_Click(object sender, EventArgs e)
		{
			int index = listBox3.SelectedIndex;
			var part = parts[index];
			await client.DeletePartAsync(part.Id);
			await UpdatePartsList();
		}

		private async Task UpdatePartsList()
		{
			var parts = await client.GetPartsAsync();
			if (parts == null)
			{
				MessageBox.Show("Не удалось получить список деталей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.parts = parts;
			listBox3.Items.Clear();
			listBox3.Items.AddRange(parts.Select(x => x.Name).ToArray());
		}

		private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			button6.Enabled = true;
		}

		private void listBox3_DoubleClick(object sender, EventArgs e)
		{
			int index = listBox3.SelectedIndex;
			if (index == -1)
				return;

			var part = parts[index];
			MessageBox.Show($"Название: {part.Name}\n" +
							$"Описание: {part.Description}", "Данные о детали");
		}

		#endregion
	}
}
