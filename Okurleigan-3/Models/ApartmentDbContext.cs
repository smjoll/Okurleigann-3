using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleigan_3.Models
{
    class ApartmentDbContext : DbContext
    {
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        //public DbSet<Status> Statuses { get; set; }
    }
}
