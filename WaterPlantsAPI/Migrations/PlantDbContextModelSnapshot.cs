// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WaterPlantsAPI.Data;

namespace WaterPlantsAPI.Migrations
{
    [DbContext(typeof(PlantDbContext))]
    partial class PlantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WaterPlantsAPI.Models.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("lastWatered")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Plant");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            lastWatered = new DateTime(2021, 4, 6, 12, 3, 10, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            lastWatered = new DateTime(2021, 4, 6, 12, 3, 10, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            lastWatered = new DateTime(2021, 4, 6, 12, 3, 10, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            lastWatered = new DateTime(2021, 4, 6, 12, 3, 10, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            lastWatered = new DateTime(2021, 4, 6, 12, 3, 10, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
