using Microsoft.EntityFrameworkCore;
using StarFleetBattles.Models;

namespace StarFleetBattles.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options
            ) : base(options) {}

        public DbSet<EnergyAllocationForm> EnergyAllocationForms { get; set; }
    }
}
