using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Whyne.DAL.Migrations
{
    public partial class CompleteCustomerOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BillingAdressId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryAdressId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillingAdressId",
                table: "Orders",
                column: "BillingAdressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryAdressId",
                table: "Orders",
                column: "DeliveryAdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Adresses_BillingAdressId",
                table: "Orders",
                column: "BillingAdressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Adresses_DeliveryAdressId",
                table: "Orders",
                column: "DeliveryAdressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Adresses_BillingAdressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Adresses_DeliveryAdressId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_BillingAdressId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DeliveryAdressId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BillingAdressId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryAdressId",
                table: "Orders");
        }
    }
}
