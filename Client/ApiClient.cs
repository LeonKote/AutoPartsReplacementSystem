using Api.Modules.Car.Dto;
using Api.Modules.Part.Dto;
using Api.Modules.PartReplacement.Dto;
using Domain.Models;
using System.Net.Http.Json;

namespace Client
{
	public class ApiClient
	{
		private readonly HttpClient httpClient;

		public ApiClient(string baseUrl)
		{
			httpClient = new HttpClient
			{
				BaseAddress = new Uri(baseUrl)
			};
		}

		// Cars
		public async Task<List<Car>?> GetCarsAsync(GetCarsRequest request)
		{
			// Bad Request при int = null
			var response = await httpClient.GetAsync($"cars?make={request.Make}&model={request.Model}&minYear={request.MinYear ?? 0}&maxYear={request.MaxYear ?? int.MaxValue}");
			if (response.IsSuccessStatusCode)
				return await response.Content.ReadFromJsonAsync<List<Car>>();
			return null;
		}

		public async Task<bool> AddCarAsync(AddCarRequest request)
		{
			var response = await httpClient.PostAsJsonAsync("cars", request);
			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteCarAsync(Guid carId)
		{
			var response = await httpClient.DeleteAsync($"cars/{carId}");
			return response.IsSuccessStatusCode;
		}

		// Parts
		public async Task<List<Part>?> GetPartsAsync()
		{
			var response = await httpClient.GetAsync("parts");
			if (response.IsSuccessStatusCode)
				return await response.Content.ReadFromJsonAsync<List<Part>>();
			return null;
		}

		public async Task<bool> AddPartAsync(AddPartRequest request)
		{
			var response = await httpClient.PostAsJsonAsync("parts", request);
			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeletePartAsync(Guid partId)
		{
			var response = await httpClient.DeleteAsync($"parts/{partId}");
			return response.IsSuccessStatusCode;
		}

		// Part Replacements
		public async Task<List<PartReplacement>?> GetPartReplacementsAsync(Guid carId)
		{
			var response = await httpClient.GetAsync($"partReplacements/{carId}");
			if (response.IsSuccessStatusCode)
				return await response.Content.ReadFromJsonAsync<List<PartReplacement>>();
			return null;
		}

		public async Task<bool> AddPartReplacementAsync(AddPartReplacementRequest request)
		{
			var response = await httpClient.PostAsJsonAsync("partReplacements/part-replacement", request);
			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeletePartReplacementAsync(Guid partReplacementId)
		{
			var response = await httpClient.DeleteAsync($"partReplacements/part-replacement/{partReplacementId}");
			return response.IsSuccessStatusCode;
		}
	}
}
