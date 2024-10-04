using Manager.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder
            .HasMany(x => x.Schedules)
            .WithOne(x => x.Subject)
            .HasForeignKey(x => x.SubjectId);

        builder
            .HasMany(x => x.Lecturers)
            .WithMany(x => x.Subjects);
    }
}