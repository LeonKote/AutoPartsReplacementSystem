using CSharpFunctionalExtensions;
using Infrastructure.Services.PartReplacement.Dto;
using Infrastructure.Storage;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.PartReplacement;

public class PartReplacementService(AppDbContext dbContext): IPartReplacementService
{
    public async Task<Result<List<Domain.Models.PartReplacement>, string>> GetPartReplacementsForCarAsync(Guid carId)
    {
        var replacements = await dbContext.PartReplacements
            .Include(r => r.Car)
            .Include(r => r.Part)
            .Where(r => r.Car.Id == carId)
            .ToListAsync();
        
        return replacements;
    }

    public async Task<Result<Guid, string>> AddPartReplacementAsync(AddPartReplacementBody body)
    {
        var car = await dbContext.Cars.FirstOrDefaultAsync(c => c.Id == body.CarId);
        if (car is null)
        {
            return "Машина не найдена";
        }
        
        var part = await dbContext.Parts.FirstOrDefaultAsync(p => p.Id == body.PartId);
        if (part is null)
        {
            return "Деталь не найдена";
        }
        
        var replacement = new Domain.Models.PartReplacement(car, part, body.Date);
        dbContext.PartReplacements.Add(replacement);
        await dbContext.SaveChangesAsync();
        
        return replacement.Id;
    }

    public async Task<UnitResult<string>> DeletePartReplacementAsync(Guid partReplacementId)
    {
        var replacement = dbContext.PartReplacements
            .FirstOrDefault(r => r.Id == partReplacementId);
        if (replacement is null)
        {
            return "Замена не найдена";
        }
        
        dbContext.PartReplacements.Remove(replacement);
        await dbContext.SaveChangesAsync();
        
        return UnitResult.Success<string>();
    }
}