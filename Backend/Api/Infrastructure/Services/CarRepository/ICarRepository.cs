using CSharpFunctionalExtensions;

namespace Infrastructure.Services.CarRepository;

public interface ICarRepository: IRepository<Domain.Models.Car>;