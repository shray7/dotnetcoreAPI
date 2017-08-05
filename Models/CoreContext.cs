using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
namespace Core.Api.Models
{
    public partial class CoreContext : DbContext
    {
        public virtual DbSet<Beers> Beers { get; set; }
        public virtual DbSet<Brewery> Brewery { get; set; }
        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // TODO come back to this and inject the connection string
        //    optionsBuilder.UseSqlServer(@"Server=tcp:wcb6doyo9l.database.windows.net,1433;Initial Catalog=Core;Persist Security Info=False;User ID=shray;Password=Pass@word1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Beers>(entity =>
        //    {
        //        entity.Property(e => e.Id)
        //            .HasColumnName("ID")
        //            .ValueGeneratedNever();

        //        entity.Property(e => e.Abv)
        //            .HasColumnName("abv")
        //            .HasColumnType("varchar(40)");

        //        entity.Property(e => e.Bid).HasColumnName("bid");

        //        entity.Property(e => e.BreweryId).HasColumnName("breweryId");

        //        entity.Property(e => e.Ibu).HasColumnName("ibu");

        //        entity.Property(e => e.Name)
        //            .HasColumnName("name")
        //            .HasColumnType("varchar(200)");

        //        entity.Property(e => e.Ounces).HasColumnName("ounces");

        //        entity.Property(e => e.Style)
        //            .HasColumnName("style")
        //            .HasColumnType("varchar(200)");
        //    });

        //    modelBuilder.Entity<Brewery>(entity =>
        //    {
        //        entity.Property(e => e.BreweryId)
        //            .HasColumnName("BreweryID")
        //            .ValueGeneratedNever();

        //        entity.Property(e => e.City).HasColumnType("varchar(100)");

        //        entity.Property(e => e.Name).HasColumnType("varchar(200)");

        //        entity.Property(e => e.State).HasColumnType("varchar(4)");
        //    });
        //}
    }
}