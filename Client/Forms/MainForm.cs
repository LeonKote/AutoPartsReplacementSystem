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
			client = new ApiClient("https://localhost:7281");
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			await UpdateCarList();
			await UpdatePartsList();
		}

		#region Cars

		private async void addCarButton_Click(object sender, EventArgs e)
		{
			using var form = new CarForm();
			if (form.ShowDialog() == DialogResult.Cancel)
				return;

			await client.AddCarAsync(form.AddCarRequest!);
			await UpdateCarList();
		}

		private async void deleteCarButton_Click(object sender, EventArgs e)
		{
			int index = carListBox.SelectedIndex;
			var car = cars[index];
			await client.DeleteCarAsync(car.Id);
			await UpdateCarList();
		}

		private async Task UpdateCarList()
		{
			deleteCarButton.Enabled = false;
			addPartReplacementButton.Enabled = false;
			deletePartReplacementButton.Enabled = false;
			partReplacementListBox.Items.Clear();
			var cars = await client.GetCarsAsync(new GetCarsRequest());
			if (cars == null)
			{
				ShowError("Не удалось получить список автомобилей");
				return;
			}

			this.cars = cars;
			carListBox.Items.Clear();
			carListBox.Items.AddRange(cars.Select(x => $"{x.Make} {x.Model} {x.Year}").ToArray());
		}

		private async void carListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = carListBox.SelectedIndex;
			var car = cars[index];
			deleteCarButton.Enabled = true;
			await UpdatePartReplacementsList(car.Id);
		}

		private void carListBox_DoubleClick(object sender, EventArgs e)
		{
			int index = carListBox.SelectedIndex;
			if (index == -1)
				return;

			var car = cars[index];
			MessageBox.Show($"Марка: {car.Make}\n" +
							$"Модель: {car.Model}\n" +
							$"Год выпуска: {car.Year}", "Данные об автомобиле");
		}

		#endregion

		#region PartReplacements

		private async void addPartReplacementButton_Click(object sender, EventArgs e)
		{
			using var form = new PartReplacementForm(parts, partListBox.SelectedIndex);
			if (form.ShowDialog() == DialogResult.Cancel)
				return;

			int index = carListBox.SelectedIndex;
			var car = cars[index];
			form.AddPartReplacementRequest!.CarId = car.Id;
			await client.AddPartReplacementAsync(form.AddPartReplacementRequest!);
			await UpdatePartReplacementsList(car.Id);
		}

		private async void deletePartReplacementButton_Click(object sender, EventArgs e)
		{
			int carIndex = carListBox.SelectedIndex;
			int partIndex = partReplacementListBox.SelectedIndex;
			var car = cars[carIndex];
			var part = partReplacements[partIndex];
			await client.DeletePartReplacementAsync(part.Id);
			await UpdatePartReplacementsList(car.Id);
		}

		private async Task UpdatePartReplacementsList(Guid carId)
		{
			deletePartReplacementButton.Enabled = false;
			var partReplacements = await client.GetPartReplacementsAsync(carId);
			if (partReplacements == null)
			{
				ShowError("Не удалось получить список замененных деталей");
				return;
			}

			this.partReplacements = partReplacements;
			partReplacementListBox.Items.Clear();
			partReplacementListBox.Items.AddRange(partReplacements.Select(x => x.Part.Name).ToArray());
			addPartReplacementButton.Enabled = true;
		}

		private void partReplacementListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			deletePartReplacementButton.Enabled = true;
		}

		private void partReplacementListBox_DoubleClick(object sender, EventArgs e)
		{
			int index = partReplacementListBox.SelectedIndex;
			if (index == -1)
				return;

			var partReplacement = partReplacements[index];
			MessageBox.Show($"Название: {partReplacement.Part.Name}\n" +
							$"Описание: {partReplacement.Part.Description}\n" +
							$"Дата замены: {partReplacement.Date}", "Данные о замененной детали");
		}

		#endregion

		#region Parts

		private async void addPartButton_Click(object sender, EventArgs e)
		{
			using var form = new PartForm();
			if (form.ShowDialog() == DialogResult.Cancel)
				return;

			await client.AddPartAsync(form.AddPartRequest!);
			await UpdatePartsList();
		}

		private async void deletePartButton_Click(object sender, EventArgs e)
		{
			int index = partListBox.SelectedIndex;
			var part = parts[index];
			await client.DeletePartAsync(part.Id);
			await UpdatePartsList();
		}

		private async Task UpdatePartsList()
		{
			var parts = await client.GetPartsAsync();
			if (parts == null)
			{
				ShowError("Не удалось получить список деталей");
				return;
			}

			this.parts = parts;
			partListBox.Items.Clear();
			partListBox.Items.AddRange(parts.Select(x => x.Name).ToArray());
		}

		private void PartListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			deletePartButton.Enabled = true;
		}

		private void PartListBox_DoubleClick(object sender, EventArgs e)
		{
			int index = partListBox.SelectedIndex;
			if (index == -1)
				return;

			var part = parts[index];
			MessageBox.Show($"Название: {part.Name}\n" +
							$"Описание: {part.Description}", "Данные о детали");
		}

		#endregion

		private bool ShowError(string message)
		{
			MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
	}
}
