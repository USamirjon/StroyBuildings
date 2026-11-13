using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StroyBuildings.Api.Modules.Identity.Domain;

namespace StroyBuildings.Api.Modules.Identity.Infrastructure;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles");
        builder.HasData(
            new Role
            {
                Id = new Guid("d398b131-9ced-4f04-8ff3-d1174783288e"),
                Name = "Client",
                NormalizedName = "CLIENT",
                ConcurrencyStamp = "29c5caf6-2380-4944-9658-961ad243def3"
            },
            new Role
            {
                Id = new Guid("d7ed4247-40f1-4998-a6c1-410630ba530f"),
                Name = "Master",
                NormalizedName = "MASTER",
                ConcurrencyStamp = "98a74e51-5df6-4591-b534-20a795abf777"
            },
            new Role
            {
                Id = new Guid("801b1c6d-c462-417e-9d75-b71030485e8f"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "4da23fa8-1535-4510-ba16-96522ec5b3a2"
            }
        );
    }
}