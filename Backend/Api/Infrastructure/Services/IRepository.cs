namespace Infrastructure.Services;

public interface IRepository<T>
{
	IQueryable<T> Get();
	Task AddAsync(T model);
	Task RemoveAsync(Guid id);
}