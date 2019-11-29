using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Odeljenja",
                columns: new[] { "Id", "Naziv" },
                values: new object[] { 1, "Finansije" });

            migrationBuilder.InsertData(
                table: "Odeljenja",
                columns: new[] { "Id", "Naziv" },
                values: new object[] { 2, "Prodaja" });

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "ZaposleniId", "Ime", "OdeljenjeId", "Prezime" },
                values: new object[] { 1, "Pera", 2, "Peric" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Odeljenja",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "ZaposleniId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Odeljenja",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
