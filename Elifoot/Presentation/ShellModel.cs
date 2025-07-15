using Elifoot.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace Elifoot.Presentation;

public class ShellModel
{
    public ShellModel(INavigator navigator, IDbContextFactory<AppDbContext> dbContextFactory)
    {
        _ = navigator;
        using var dbContext = dbContextFactory.CreateDbContext();
        dbContext.Database.EnsureDeleted();
        dbContext.Database.EnsureCreated();
        dbContext.SaveChanges();
    }
}
