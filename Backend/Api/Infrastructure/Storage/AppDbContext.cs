using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Storage;

public class AppDbContext(IConfiguration configuration, DbContextOptions<AppDbContext> options) : DbContext(options)
{
	public DbSet<Car> Cars { get; set; }
	public DbSet<Part> Parts { get; set; }
	public DbSet<PartReplacement> PartReplacements { get; set; }


	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
	}
}