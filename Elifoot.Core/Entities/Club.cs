using System.Drawing;

namespace Elifoot.Core.Entities;

public sealed class Club
{
    public Guid ClubId { get; set; }
    public required string Name { get; set; }
    public required Color PrimaryColor { get; set; }
    public required Color SecondaryColor { get; set; }
    public required Stadium Stadium { get; set; }
    public ClubStats Stats { get; set; } = new();
    public string CountryCode { get; set; } = default!;
    public Country Country { get; set; } = default!;
    public Guid CoachId { get; set; }
    public Coach Coach { get; set; } = default!;
    public List<Contract> Contracts { get; set; } = [];
    public IEnumerable<Player> Players => Contracts.Select(x => x.Player);
}

public sealed class Stadium
{
    public required string Name { get; set; }
    public int SeatCount { get; set; }
    public int SeatPrice { get; set; }
}

public sealed class ClubStats
{
    public int Wins { get; set; }
    public int Draws { get; set; }
    public int Losses { get; set; }
    public int Morale { get; set; }
    public float BankTrust { get; set; }
    public int Capital { get; set; }
    public int Debt { get; set; }
}
