using Api.Modules.PartReplacement.Dto;
using CSharpFunctionalExtensions;
using Infrastructure.Services.PartReplacement;
using Infrastructure.Services.PartReplacement.Dto;
using Microsoft.AspNetCore.Mvc;
using IResult = Microsoft.AspNetCore.Http.IResult;

namespace Api.Modules.PartReplacement;

public static class PartReplacementModule
{
    public static void AddPartReplacementEndpoints(this IEndpointRouteBuilder app)
    {
        var module = app
            .MapGroup("partReplacements");

        module.MapGet("/{carId:guid}", GetPartReplacementsAsync);
        module.MapPost("/part-replacement", AddPartReplacementAsync);
        module.MapDelete("/part-replacement/{partReplacementId:guid}", DeletePartReplacementAsync);
    }

    private static async Task<IResult> GetPartReplacementsAsync(Guid carId,
        IPartReplacementService partReplacementService)
    {
        var result = await partReplacementService.GetPartReplacementsForCarAsync(carId);
        return result.Match(Results.Ok, Results.NotFound);
    }

    private static async Task<IResult> AddPartReplacementAsync([FromBody] AddPartReplacementRequest request,
        IPartReplacementService partReplacementService)
    {
        var result =
            await partReplacementService.AddPartReplacementAsync(
                new AddPartReplacementBody(request.CarId, request.PartId, request.Date));
        return result.Match(Results.Ok, Results.BadRequest);
    }

    private static async Task<IResult> DeletePartReplacementAsync(Guid partReplacementId,
        IPartReplacementService partReplacementService)
    {
        var result = await partReplacementService.DeletePartReplacementAsync(partReplacementId);
        return result.Match(Results.NoContent, Results.NotFound);
    }
}