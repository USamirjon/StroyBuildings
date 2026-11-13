using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StroyBuildings.Api.Modules.Identity.Domain;

namespace StroyBuildings.Api.Modules.Identity.Infrastructure;

public class UserConfiguration: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        builder.Property(x=>x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x=>x.AvatarUrl).HasMaxLength(500);
        builder.Property(x => x.PhoneNumber).HasMaxLength(20);
        builder.HasIndex(x=>x.PhoneNumber).IsUnique();
    }
}