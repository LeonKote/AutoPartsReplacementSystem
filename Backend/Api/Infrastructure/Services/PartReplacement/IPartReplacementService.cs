using CSharpFunctionalExtensions;
using Infrastructure.Services.PartReplacement.Dto;

namespace Infrastructure.Services.PartReplacement;

public interface IPartReplacementService
{
    Task<Result<List<Domain.Models.PartReplacement>,string>> GetPartReplacementsForCarAsync(Guid carId);
    Task<Result<Guid, string>> AddPartReplacementAsync(AddPartReplacementBody body);
    Task<UnitResult<string>> DeletePartReplacementAsync(Guid partReplacementId);
}