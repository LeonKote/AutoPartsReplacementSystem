using CSharpFunctionalExtensions;
using Infrastructure.Services.Car.Dto;
using Infrastructure.Storage;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.Car;

public class CarService(AppDbContext dbContext) : ICarService
{
    public async Task<Result<List<Domain.Models.Car>, string>> GetCarsAsync(GetCarsBody body)
    {
        var query = dbContext.Cars.AsQueryable();

        if (!string.IsNullOrEmpty(body.Make))
        {
            query = query.Where(c => c.Make == body.Make);
        }

        if (!string.IsNullOrEmpty(body.Model))
        {
            query = query.Where(c => c.Model == body.Model);
        }

        if (body.MinYear is not null)
        {
            query = query.Where(c => c.Year >= body.MinYear);
        }

        if (body.MaxYear is not null)
        {
            query = query.Where(c => c.Year <= body.MaxYear);
        }

        var cars = await query.ToListAsync();
        return cars;
    }

    public async Task<Result<Guid, string>> AddCarAsync(AddCarBody body)
    {
        var car = new Domain.Models.Car(body.Make, body.Model, body.Year);
        dbContext.Cars.Add(car);

        await dbContext.SaveChangesAsync();
        return car.Id;
    }

    public async Task<UnitResult<string>> DeleteCarAsync(Guid carId)
    {
        var car = await dbContext.Cars.FirstOrDefaultAsync(c => c.Id == carId);

        if (car is null)
        {
            return "Машина не найдена";
        }
        
        dbContext.Cars.Remove(car);
        await dbContext.SaveChangesAsync();
        return UnitResult.Success<string>();
    }
}