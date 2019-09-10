using Microsoft.EntityFrameworkCore.Migrations;

namespace AlamoCorp.Web.API.Migrations
{
    public partial class ModelModif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_BillingAddressID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_ShippingAddressID",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Products",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Orders",
                newName: "OrderID");

            migrationBuilder.RenameColumn(
                name: "ShippingAddressID",
                table: "Customers",
                newName: "ShippingAddressAddressID");

            migrationBuilder.RenameColumn(
                name: "BillingAddressID",
                table: "Customers",
                newName: "BillingAddressAddressID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customers",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_ShippingAddressID",
                table: "Customers",
                newName: "IX_Customers_ShippingAddressAddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_BillingAddressID",
                table: "Customers",
                newName: "IX_Customers_BillingAddressAddressID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Addresses",
                newName: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_BillingAddressAddressID",
                table: "Customers",
                column: "BillingAddressAddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_ShippingAddressAddressID",
                table: "Customers",
                column: "ShippingAddressAddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_BillingAddressAddressID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_ShippingAddressAddressID",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Products",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Orders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ShippingAddressAddressID",
                table: "Customers",
                newName: "ShippingAddressID");

            migrationBuilder.RenameColumn(
                name: "BillingAddressAddressID",
                table: "Customers",
                newName: "BillingAddressID");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Customers",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_ShippingAddressAddressID",
                table: "Customers",
                newName: "IX_Customers_ShippingAddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_BillingAddressAddressID",
                table: "Customers",
                newName: "IX_Customers_BillingAddressID");

            migrationBuilder.RenameColumn(
                name: "AddressID",
                table: "Addresses",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_BillingAddressID",
                table: "Customers",
                column: "BillingAddressID",
                principalTable: "Addresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_ShippingAddressID",
                table: "Customers",
                column: "ShippingAddressID",
                principalTable: "Addresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
