namespace Elifoot.Core.Entities;

public sealed class Country
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public string RegionName { get; set; } = default!;
    public Region Region { get; set; } = default!;
}
