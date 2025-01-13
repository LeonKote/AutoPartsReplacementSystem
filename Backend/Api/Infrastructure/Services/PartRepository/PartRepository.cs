using Infrastructure.Storage;

namespace Infrastructure.Services.PartRepository;

public class PartRepository(AppDbContext dbContext) : IPartRepository
{
	public IQueryable<Domain.Models.Part> Get()
	{
		return dbContext.Parts;
	}

	public async Task AddAsync(Domain.Models.Part model)
	{
		dbContext.Parts.Add(model);
		await dbContext.SaveChangesAsync();
	}

	public Task RemoveAsync(Guid id)
	{
		var part = dbContext.Parts.FirstOrDefault(p => p.Id == id);
		if (part != null)
		{
			dbContext.Remove(part);
			return dbContext.SaveChangesAsync();
		}

		return Task.CompletedTask;
	}
}