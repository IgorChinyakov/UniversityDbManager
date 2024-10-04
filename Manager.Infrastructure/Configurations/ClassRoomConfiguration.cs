using Manager.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class ClassRoomConfiguration : IEntityTypeConfiguration<ClassRoom>
{
    public void Configure(EntityTypeBuilder<ClassRoom> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasOne(x => x.Department)
            .WithMany(x => x.ClassRooms)
            .HasForeignKey(x => x.DepartmentId);

        builder
            .HasMany(x => x.Schedules)
            .WithOne(x => x.ClassRoom)
            .HasForeignKey(x => x.ClassRoomId);
    }
}