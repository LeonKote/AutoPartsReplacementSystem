using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Storage.Configurations;

public class PartReplacementConfiguration: IEntityTypeConfiguration<PartReplacement>
{
    public void Configure(EntityTypeBuilder<PartReplacement> builder)
    {
        builder.ToTable("PartReplacements").HasKey(p => p.Id);
    }
}