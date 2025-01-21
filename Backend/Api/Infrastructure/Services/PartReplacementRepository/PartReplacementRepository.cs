using Infrastructure.Storage;

namespace Infrastructure.Services.PartReplacementRepository;

public class PartReplacementRepository(AppDbContext dbContext) : IPartReplacementRepository
{
	public IQueryable<Domain.Models.PartReplacement> Get()
	{
		return dbContext.PartReplacements;
	}

	public async Task AddAsync(Domain.Models.PartReplacement model)
	{
		dbContext.Add(model);
		await dbContext.SaveChangesAsync();
	}

	public Task RemoveAsync(Guid id)
	{
		var replacement = dbContext.PartReplacements.FirstOrDefault(r => r.Id == id);
		if (replacement != null)
		{
			dbContext.Remove(replacement);
			return dbContext.SaveChangesAsync();
		}

		return Task.CompletedTask;
	}
}