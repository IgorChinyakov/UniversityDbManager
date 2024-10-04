using Manager.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class LecturerConfiguration : IEntityTypeConfiguration<Lecturer>
{
    public void Configure(EntityTypeBuilder<Lecturer> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder
            .HasMany(x => x.Subjects)
            .WithMany(x => x.Lecturers);

        builder
            .HasOne(x => x.Department)
            .WithMany(x => x.Lecturers)
            .HasForeignKey(x => x.Id);

        builder
            .HasMany(x => x.Schedules)
            .WithOne(x => x.Lecturer)
            .HasForeignKey(x => x.LecturerId);
    }
}