using CSharpFunctionalExtensions;
using Infrastructure.Services.Car.Dto;
using Infrastructure.Services.CarRepository;
using Infrastructure.Storage;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.Car;

public class CarService(ICarRepository carRepository) : ICarService
{
    public async Task<Result<List<Domain.Models.Car>, string>> GetCarsAsync(GetCarsBody body)
    {
        var query = carRepository.Get();

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
        await carRepository.AddAsync(car);

        return car.Id;
    }

    public async Task<UnitResult<string>> DeleteCarAsync(Guid carId)
    {
        await carRepository.RemoveAsync(carId);

        return UnitResult.Success<string>();
    }
}