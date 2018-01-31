using Microsoft.EntityFrameworkCore;
using SpringBoot.Models;

namespace SpringBoot.Entities
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LicencePlate> LicencePlates { get; set; }
    }
}
