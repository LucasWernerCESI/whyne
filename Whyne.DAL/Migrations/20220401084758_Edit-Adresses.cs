using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Whyne.DAL.Migrations
{
    public partial class EditAdresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_People_PersonId",
                table: "Adresses");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Adresses",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_PersonId",
                table: "Adresses",
                newName: "IX_Adresses_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_People_CustomerId",
                table: "Adresses",
                column: "CustomerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_People_CustomerId",
                table: "Adresses");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Adresses",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_CustomerId",
                table: "Adresses",
                newName: "IX_Adresses_PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_People_PersonId",
                table: "Adresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }
    }
}
