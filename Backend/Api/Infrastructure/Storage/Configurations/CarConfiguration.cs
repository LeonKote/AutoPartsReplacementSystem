using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Storage.Configurations;

public class CarConfiguration: IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars").HasKey(c => c.Id);

        builder.Property(c => c.Make).HasMaxLength(50);
        builder.Property(c => c.Model).HasMaxLength(50);

        builder.HasMany(c => c.PartReplacements)
            .WithOne(r => r.Car);
    }
}