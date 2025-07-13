namespace Elifoot.Core.Entities;
public sealed class Contract
{
    public Guid ClubId { get; set; }
    public Club Club { get; set; } = default!;
    public Guid PlayerId { get; set; }
    public Player Player { get; set; } = default!;
    public required int Weeks { get; set; }
    public required int Salary { get; set; }
}
