namespace Elifoot.Core.Entities;
public sealed class Coach
{
    public Guid CoachId { get; set; }
    public required string Name { get; set; }
    public CoachStats Stats { get; set; } = new CoachStats();
    public Guid ClubId { get; set; }
    public Club Club { get; set; } = default!;
}

public sealed class CoachStats
{
    public int Wins { get; set; }
    public int Draws { get; set; }
    public int Losses { get; set; }
}
