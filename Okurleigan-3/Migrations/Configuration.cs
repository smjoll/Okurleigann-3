namespace Okurleigan_3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Okurleigan_3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Okurleigan_3.Models.ApartmentDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Okurleigan_3.Models.ApartmentDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Apartments.AddOrUpdate(
                n => n.Name,
                new Apartment()
                {
                    Name = "A",
                    Size = 10,
                    RoomCount = 3,
                    
                },
                new Apartment()
                {
                    Name = "B",
                    Size = 20,
                    RoomCount = 7,
                },
                new Apartment()
                {
                    Name = "C",
                    Size = 80,
                    RoomCount = 2,
                }
                );

            context.Tenants.AddOrUpdate(
                t => new { t.FirstName, t.Lastname},
                new Tenant()
                {
                    FirstName = "Maria",
                    Lastname = "Anders",
                    DateOfBirth = new DateTime(1955, 08, 02),
                    
                },
                new Tenant()
                {
                    FirstName = "Anna",
                    Lastname = "Baldvin",
                    DateOfBirth = new DateTime(1922, 01, 26),                  
                },
                new Tenant()
                {
                    FirstName = "Sara",
                    Lastname = "Williams",
                    DateOfBirth = new DateTime(1989, 04, 15),                 
                },
                new Tenant()
                {
                    FirstName = "Steven",
                    Lastname = "Sparkling",
                    DateOfBirth = new DateTime(1943, 11, 02),                    
                },
                new Tenant()
                {
                    FirstName = "Claudio",
                    Lastname = "Bird",
                    DateOfBirth = new DateTime(1970, 10, 20),                 
                }

                );

        }

    }
}
