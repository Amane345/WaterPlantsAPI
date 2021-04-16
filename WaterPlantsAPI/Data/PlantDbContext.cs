using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterPlantsAPI.Models;

namespace WaterPlantsAPI.Data
{
    public class PlantDbContext : DbContext
    {
        public PlantDbContext(DbContextOptions<PlantDbContext> options)
        : base(options) { }
        public DbSet<Plant> Plant { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plant>()
                .ToTable("Plant");

            modelBuilder.Entity<Plant>()
                .HasData(
                    new Plant
                    {
                        Id = 1,
                        lastWatered = new DateTime(2021, 04, 06, 12, 03, 10) 

                    },
                    new Plant
                    {
                        Id = 2,
                        lastWatered = new DateTime(2021, 04, 06, 12, 03, 10)

                    },
                    new Plant
                    {
                        Id = 3,
                        lastWatered = new DateTime(2021, 04, 06, 12, 03, 10)

                    },
                    new Plant
                    {
                        Id = 4,
                        lastWatered = new DateTime(2021, 04, 06, 12, 03, 10)

                    },
                    new Plant
                    {
                        Id = 5,
                        lastWatered = new DateTime(2021, 04, 06, 12, 03, 10)

                    }
                );
        }
    }

}
