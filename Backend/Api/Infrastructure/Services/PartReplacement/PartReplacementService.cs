using CSharpFunctionalExtensions;
using Infrastructure.Services.CarRepository;
using Infrastructure.Services.PartReplacement.Dto;
using Infrastructure.Services.PartReplacementRepository;
using Infrastructure.Services.PartRepository;
using Infrastructure.Storage;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.PartReplacement;

public class PartReplacementService(
	IPartReplacementRepository partReplacementRepository,
	ICarRepository carRepository,
	IPartRepository partRepository) : IPartReplacementService
{
	public async Task<Result<List<Domain.Models.PartReplacement>, string>> GetPartReplacementsForCarAsync(Guid carId)
	{
		var replacements = await partReplacementRepository.Get()
			.Include(r => r.Part)
			.Include(r => r.Car)
			.Where(c => c.Car.Id == carId)
			.ToListAsync();


		return replacements;
	}

	public async Task<Result<Guid, string>> AddPartReplacementAsync(AddPartReplacementBody body)
	{
		var car = await carRepository.Get()
			.FirstOrDefaultAsync(c => c.Id == body.CarId);
		if (car is null)
			return "Машина не найдена";

		var part = await partRepository.Get()
			.FirstOrDefaultAsync(p => p.Id == body.PartId);
		if (part is null)
			return "Деталь не найдена";
		
		var replacement = new Domain.Models.PartReplacement(car, part, body.Date);
		await partReplacementRepository.AddAsync(replacement);

		return replacement.Id;
	}

	public async Task<UnitResult<string>> DeletePartReplacementAsync(Guid partReplacementId)
	{
		await partReplacementRepository.RemoveAsync(partReplacementId);

		return UnitResult.Success<string>();
	}
}