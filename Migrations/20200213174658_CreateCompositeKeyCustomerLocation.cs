using Microsoft.EntityFrameworkCore.Migrations;

namespace customer_consumption_api.Migrations
{
    public partial class CreateCompositeKeyCustomerLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerLocations_Customers_CustomerId1",
                table: "CustomerLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerLocations_Locations_LocationId",
                table: "CustomerLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerLocations",
                table: "CustomerLocations");

            migrationBuilder.DropIndex(
                name: "IX_CustomerLocations_CustomerId1",
                table: "CustomerLocations");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "CustomerLocations");

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "CustomerLocations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerLocations",
                table: "CustomerLocations",
                columns: new[] { "CustomerId", "LocationId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerLocations_Customers_CustomerId",
                table: "CustomerLocations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerLocations_Locations_LocationId",
                table: "CustomerLocations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerLocations_Customers_CustomerId",
                table: "CustomerLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerLocations_Locations_LocationId",
                table: "CustomerLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerLocations",
                table: "CustomerLocations");

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "CustomerLocations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "CustomerId1",
                table: "CustomerLocations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerLocations",
                table: "CustomerLocations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLocations_CustomerId1",
                table: "CustomerLocations",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerLocations_Customers_CustomerId1",
                table: "CustomerLocations",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerLocations_Locations_LocationId",
                table: "CustomerLocations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
