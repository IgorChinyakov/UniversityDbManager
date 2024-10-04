using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Entities.Group>
{
    public void Configure(EntityTypeBuilder<Entities.Group> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasMany(x => x.Students)
            .WithOne(x => x.Group)
            .HasForeignKey(x => x.GroupId);

        builder
            .HasMany(x => x.Schedules)
            .WithOne(x => x.Group)
            .HasForeignKey(x => x.GroupId);
    }
}