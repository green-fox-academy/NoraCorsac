using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
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
