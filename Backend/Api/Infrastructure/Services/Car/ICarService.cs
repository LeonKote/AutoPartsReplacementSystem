using CSharpFunctionalExtensions;
using Infrastructure.Services.Car.Dto;

namespace Infrastructure.Services.Car;

public interface ICarService
{
    Task<Result<List<Domain.Models.Car>, string>> GetCarsAsync(GetCarsBody body);
    Task<Result<Guid, string>> AddCarAsync(AddCarBody body);
    Task<UnitResult<string>> DeleteCarAsync(Guid carId);
}