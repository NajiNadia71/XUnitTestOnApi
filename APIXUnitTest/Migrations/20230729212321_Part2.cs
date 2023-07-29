using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIXUnitTest.Migrations
{
    public partial class Part2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Countries",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Countries",
                newName: "CountryId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Continents",
                newName: "ContinentName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Continents",
                newName: "ContinentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Countries",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Countries",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ContinentName",
                table: "Continents",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ContinentId",
                table: "Continents",
                newName: "Id");
        }
    }
}
