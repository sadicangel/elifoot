using Elifoot.Core.Entities;

namespace Elifoot.Presentation;

public partial class ClubModel(Club club, IStringLocalizer localizer, INavigator navigator)
{
    public string Title => club.Name;

    public IEnumerable<Player> Players => club.Players.OrderBy(x => x.Position);

    public async Task GoBack()
    {
        await navigator.NavigateBackAsync(this);
    }
}
