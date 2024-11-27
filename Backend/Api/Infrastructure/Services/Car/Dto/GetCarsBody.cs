namespace Infrastructure.Services.Car.Dto;

public record GetCarsBody(string? Make, string? Model, int? MinYear, int? MaxYear);