using System.Drawing;
using Elifoot.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Elifoot.Core.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Region>(t => t.HasKey(x => x.Name));

        modelBuilder.Entity<Country>(t =>
        {
            t.HasKey(x => x.Code);
            t.HasOne(x => x.Region).WithMany(x => x.Countries).HasForeignKey(x => x.RegionName);
        });

        modelBuilder.Entity<Club>(t =>
        {
            t.HasKey(x => x.ClubId);
            t.Property(x => x.PrimaryColor).HasConversion(x => x.ToArgb(), x => Color.FromArgb(x));
            t.Property(x => x.SecondaryColor).HasConversion(x => x.ToArgb(), x => Color.FromArgb(x));
            t.OwnsOne(x => x.Stadium);
            t.OwnsOne(x => x.Stats);
            t.HasOne(x => x.Country).WithMany().HasForeignKey(x => x.CountryCode).IsRequired();
            t.HasOne(x => x.Coach).WithOne().HasForeignKey<Club>(x => x.CoachId);
            t.Ignore(x => x.Players);
        });

        modelBuilder.Entity<Player>(t =>
        {
            t.HasKey(x => x.PlayerId);
            t.HasOne(x => x.Country).WithMany().HasForeignKey(x => x.CountryCode);
            t.OwnsOne(x => x.Stats);
            t.Ignore(x => x.Club);
        });

        modelBuilder.Entity<Coach>(t =>
        {
            t.HasKey(x => x.CoachId);
            t.OwnsOne(x => x.Stats);
            t.HasOne(x => x.Club).WithOne(x => x.Coach).HasForeignKey<Coach>(x => x.ClubId);
        });

        modelBuilder.Entity<Contract>(t =>
        {
            t.HasKey(x => new { x.ClubId, x.PlayerId });
            t.HasOne(x => x.Club).WithMany(x => x.Contracts).HasForeignKey(x => x.ClubId);
            t.HasOne(x => x.Player).WithOne(x => x.Contract).HasForeignKey<Contract>(x => x.PlayerId);
        });
    }
}
