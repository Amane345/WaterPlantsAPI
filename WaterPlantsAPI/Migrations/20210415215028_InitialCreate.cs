using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WaterPlantsAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastWatered = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Plant",
                columns: new[] { "Id", "lastWatered" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 6, 12, 3, 10, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2021, 4, 6, 12, 3, 10, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2021, 4, 6, 12, 3, 10, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2021, 4, 6, 12, 3, 10, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2021, 4, 6, 12, 3, 10, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plant");
        }
    }
}
