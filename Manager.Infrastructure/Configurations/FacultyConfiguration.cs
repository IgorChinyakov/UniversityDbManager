using Manager.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
{
    public void Configure(EntityTypeBuilder<Faculty> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder
            .HasMany(x => x.Departments)
            .WithOne(x => x.Faculty)
            .HasForeignKey(x => x.FacultyId);
    }
}