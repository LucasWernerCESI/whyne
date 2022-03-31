using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Whyne.DAL.Migrations
{
    public partial class CompleteCustomerDistributor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DistributorId",
                table: "Orders",
                column: "DistributorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Corporations_DistributorId",
                table: "Orders",
                column: "DistributorId",
                principalTable: "Corporations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Corporations_DistributorId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DistributorId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Orders");
        }
    }
}
