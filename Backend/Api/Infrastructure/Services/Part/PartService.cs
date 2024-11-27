using CSharpFunctionalExtensions;
using Infrastructure.Services.Part.Dto;
using Infrastructure.Storage;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.Part;

public class PartService(AppDbContext dbContext): IPartService
{
    public async Task<Result<List<Domain.Models.Part>, string>> GetPartsAsync()
    {
        var parts = await dbContext.Parts.ToListAsync();
        return parts;
    }

    public async Task<Result<Guid, string>> AddPartAsync(AddPartBody body)
    {
        var part = new Domain.Models.Part(body.Name, body.Description);
        
        dbContext.Parts.Add(part);
        await dbContext.SaveChangesAsync();

        return part.Id;
    }

    public async Task<UnitResult<string>> DeletePartAsync(Guid partId)
    {
        var part = dbContext.Parts.FirstOrDefault(p => p.Id == partId);
        if (part is null)
        {
            return "Деталь не найдена";
        }
        
        dbContext.Parts.Remove(part);
        await dbContext.SaveChangesAsync();
        return UnitResult.Success<string>();
    }
}