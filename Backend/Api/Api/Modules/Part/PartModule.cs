using Api.Modules.Part.Dto;
using CSharpFunctionalExtensions.ValueTasks;
using Infrastructure.Services.Part;
using Infrastructure.Services.Part.Dto;
using Microsoft.AspNetCore.Mvc;
using ResultExtensions = CSharpFunctionalExtensions.ResultExtensions;

namespace Api.Modules.Part;

public static class PartModule
{
    public static void AddPartEndpoints(this IEndpointRouteBuilder app)
    {
        var module = app
            .MapGroup("parts");
        
        module.MapGet("/", GetPartsAsync);
        module.MapPost("/", AddPartAsync);
        module.MapDelete("/{partId:guid}", DeletePartAsync);
    }

    private static async Task<IResult> GetPartsAsync(IPartService partService)
    {
        var result = await partService.GetPartsAsync();
        return ResultExtensions.Match(result, Results.Ok, Results.NotFound);
    }
    
    private static async Task<IResult> AddPartAsync([FromBody] AddPartRequest request, IPartService partService)
    {
        var result = await partService.AddPartAsync(new AddPartBody(request.Name, request.Description));
        return ResultExtensions.Match(result, Results.Ok, Results.BadRequest);
    }
    
    private static async Task<IResult> DeletePartAsync(Guid partId, IPartService partService)
    {
        var result = await partService.DeletePartAsync(partId);
        return ResultExtensions.Match(result, Results.NoContent, Results.NotFound);
    }
}