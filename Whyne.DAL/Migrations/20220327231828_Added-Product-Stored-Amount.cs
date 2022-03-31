using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Whyne.DAL.Migrations
{
    public partial class AddedProductStoredAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoredAmount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoredAmount",
                table: "Products");
        }
    }
}
