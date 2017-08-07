using Core.Models;
using Microsoft.EntityFrameworkCore;
namespace Core.DataLayer
{
    public partial class CoreContext : DbContext
    {
        public virtual DbSet<Beer> Beer { get; set; }
        public virtual DbSet<Brewery> Brewery { get; set; }
        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {

        }
    }
}