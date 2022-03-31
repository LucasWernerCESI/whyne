using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Whyne.DAL.Migrations
{
    public partial class InheritanceProductCorporationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Products",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "VAT",
                table: "Corporations",
                newName: "TaxNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Products",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "TaxNumber",
                table: "Corporations",
                newName: "VAT");
        }
    }
}
