namespace Elifoot.Core.Entities;

public sealed class Region
{
    public required string Name { get; set; }
    public List<Country> Countries { get; set; } = [];
}
