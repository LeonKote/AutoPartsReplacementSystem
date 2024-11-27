using CSharpFunctionalExtensions;
using Infrastructure.Services.Part.Dto;

namespace Infrastructure.Services.Part;

public interface IPartService
{
    Task<Result<List<Domain.Models.Part>, string>> GetPartsAsync();
    Task<Result<Guid, string>> AddPartAsync(AddPartBody body);
    Task<UnitResult<string>> DeletePartAsync(Guid partId);
}