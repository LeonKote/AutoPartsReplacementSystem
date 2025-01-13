using Infrastructure.Storage;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.CarRepository;

public class CarRepository(AppDbContext dbContext): ICarRepository
{
	public IQueryable<Domain.Models.Car> Get()
	{
		return dbContext.Cars;
	}

	public async Task AddAsync(Domain.Models.Car model)
	{
		dbContext.Add(model);
		await dbContext.SaveChangesAsync();
	}

	public async Task RemoveAsync(Guid id)
	{
		var car = await dbContext.Cars.FirstOrDefaultAsync(c => c.Id == id);
		if (car != null)
		{
			dbContext.Remove(car);
			await dbContext.SaveChangesAsync();
		}
	}
}