using Manager.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasOne(x => x.Group)
            .WithMany(x => x.Schedules)
            .HasForeignKey(x => x.Id);

        builder
            .HasOne(x => x.Lecturer)
            .WithMany(x => x.Schedules)
            .HasForeignKey(x => x.LecturerId);

        builder
            .HasOne(x => x.ClassRoom)
            .WithMany(x => x.Schedules)
            .HasForeignKey(x => x.ClassRoomId);

        builder
            .HasOne(x => x.Subject)
            .WithMany(x => x.Schedules)
            .HasForeignKey(x => x.SubjectId);
    }
}