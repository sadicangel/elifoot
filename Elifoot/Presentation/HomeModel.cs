using Elifoot.Core.Entities;

namespace Elifoot.Presentation;

public partial class HomeModel(Club club, IStringLocalizer localizer, INavigator navigator)
{
    public string Title => club.Name;

    public IEnumerable<PlayerModel> Players => club.Players.OrderBy(x => x.Position).Select(x => new PlayerModel(x));

    public async Task GoBack()
    {
        await navigator.NavigateBackAsync(this);
    }
}

public partial class PlayerModel(Player player)
{
    public string Position => player.Position switch
    {
        PlayerPosition.GoalKeeper => "G",
        PlayerPosition.Defender => "D",
        PlayerPosition.Midfielder => "M",
        PlayerPosition.Attacker => "A",
        _ => throw new NotImplementedException(),
    };

    public string Name => player.Name;

    public int Power => player.Power;

    public PlayerConduct Conduct => player.Conduct;

    public bool IsStar => player.IsStar;

    public string CountryCode => player.Country.Code;
    public string CountryName => player.Country.Name;

    public int Salary => player.Contract.Salary;

    public int Games => player.Stats.Wins + player.Stats.Draws + player.Stats.Losses;
    public int Goals => player.Stats.Goals;
    public int RedCards => player.Stats.RedCards;
    public int Injuries => player.Stats.Injuries;
}
