using Manager.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder
            .HasMany(x => x.ClassRooms)
            .WithOne(x => x.Department)
            .HasForeignKey(x => x.DepartmentId);

        builder
            .HasOne(x => x.Faculty)
            .WithMany(x => x.Departments)
            .HasForeignKey(x => x.FacultyId);

        builder
            .HasMany(x => x.Groups)
            .WithOne(x => x.Department)
            .HasForeignKey(x => x.DepartmentId);

        builder
            .HasMany(x => x.Lecturers)
            .WithOne(x => x.Department)
            .HasForeignKey(x => x.DepartmentId);
    }
}