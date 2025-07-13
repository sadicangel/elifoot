namespace Elifoot.Core.Entities;

public sealed class Player
{
    public Guid PlayerId { get; set; }
    public required string Name { get; set; }
    public string CountryCode { get; set; } = default!;
    public Country Country { get; set; } = default!;
    public required int Power { get; set; }
    public required bool IsStar { get; set; }
    public required PlayerConduct Conduct { get; set; }
    public required PlayerPosition Position { get; set; }
    public required PlayerStats Stats { get; set; }
    public required int Price { get; set; }
    public Contract Contract { get; set; } = default!;
    public Club Club => Contract.Club;
}

public enum PlayerConduct { Sanguinary, Thug, Rough, Gentleman, Harmless, FairPlay, }
public enum PlayerPosition { GoalKeeper, Defender, Midfielder, Forward }
public sealed class PlayerStats
{
    public required int Wins { get; set; }
    public required int Draws { get; set; }
    public required int Losses { get; set; }
    public required int Goals { get; set; }
    public required int RedCards { get; set; }
    public required int YellowCards { get; set; }
    public required int Injuries { get; set; }
}
