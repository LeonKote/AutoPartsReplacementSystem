using Api.Modules.Car.Dto;
using CSharpFunctionalExtensions;
using Infrastructure.Services.Car;
using Infrastructure.Services.Car.Dto;
using Microsoft.AspNetCore.Mvc;
using IResult = Microsoft.AspNetCore.Http.IResult;

namespace Api.Modules.Car;

public static class CarModule
{
    public static void AddCarEndpoints(this IEndpointRouteBuilder app)
    {
        var module = app
            .MapGroup("cars");

        module.MapGet("/", GetCarsAsync);
        module.MapPost("/", AddCarAsync);
        module.MapDelete("/{carId:guid}", DeleteCarAsync);
    }

    private static async Task<IResult> GetCarsAsync([AsParameters] GetCarsRequest request, ICarService carService)
    {
        var result =
            await carService.GetCarsAsync(
                new GetCarsBody(request.Make, request.Model, request.MinYear, request.MaxYear));

        return result.Match(Results.Ok, Results.NotFound);
    }

    private static async Task<IResult> AddCarAsync([FromBody] AddCarRequest request, ICarService carService)
    {
        var result = await carService.AddCarAsync(new AddCarBody(request.Make, request.Model, request.Year));

        return result.Match(Results.Ok, Results.BadRequest);
    }

    private static async Task<IResult> DeleteCarAsync(Guid carId, ICarService carService)
    {
        var result = await carService.DeleteCarAsync(carId);

        return result.Match(Results.NoContent, Results.NotFound);
    }
}