namespace StroyBuildings.Api.Modules.Catalog.Domain;

public class ServiceCategory
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Slug { get; set; }
    public string? IconUrl { get; set; }
    public string? Description { get; set; }
}