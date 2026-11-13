using Microsoft.AspNetCore.Identity;

namespace StroyBuildings.Api.Modules.Identity.Domain;

public class User:IdentityUser<Guid>
{
    public required string Name { get; set; }
    public string? AvatarUrl { get; set; }
    public required DateTimeOffset CreatedAt  { get; set; }
}