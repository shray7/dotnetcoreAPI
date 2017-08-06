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
    }
}