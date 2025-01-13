using CSharpFunctionalExtensions;
using Infrastructure.Services.Part.Dto;
using Infrastructure.Services.PartRepository;
using Infrastructure.Storage;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.Part;

public class PartService(IPartRepository partRepository): IPartService
{
    public async Task<Result<List<Domain.Models.Part>, string>> GetPartsAsync()
    {
        var parts = await partRepository.Get().ToListAsync();
        return parts;
    }

    public async Task<Result<Guid, string>> AddPartAsync(AddPartBody body)
    {
        var part = new Domain.Models.Part(body.Name, body.Description);

        await partRepository.AddAsync(part);
        return part.Id;
    }

    public async Task<UnitResult<string>> DeletePartAsync(Guid partId)
    {
        await partRepository.RemoveAsync(partId);
        return UnitResult.Success<string>();
    }
}