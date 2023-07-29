using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIXUnitTest.Migrations
{
    public partial class relCountryContinent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Capital",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ContinentId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CountryInformation",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SurfaceArea",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContinentInformation",
                table: "Continents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CountOfCountries",
                table: "Continents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Continents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SurfaceArea",
                table: "Continents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ContinentId",
                table: "Countries",
                column: "ContinentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Continents_ContinentId",
                table: "Countries",
                column: "ContinentId",
                principalTable: "Continents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Continents_ContinentId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_ContinentId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Capital",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ContinentId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CountryInformation",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "SurfaceArea",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ContinentInformation",
                table: "Continents");

            migrationBuilder.DropColumn(
                name: "CountOfCountries",
                table: "Continents");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "Continents");

            migrationBuilder.DropColumn(
                name: "SurfaceArea",
                table: "Continents");
        }
    }
}
