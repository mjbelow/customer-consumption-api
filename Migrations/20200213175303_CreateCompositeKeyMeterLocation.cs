using Microsoft.EntityFrameworkCore.Migrations;

namespace customer_consumption_api.Migrations
{
    public partial class CreateCompositeKeyMeterLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeterLocations_Locations_LocationId",
                table: "MeterLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_MeterLocations_Meters_MeterId1",
                table: "MeterLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations");

            migrationBuilder.DropIndex(
                name: "IX_MeterLocations_MeterId1",
                table: "MeterLocations");

            migrationBuilder.DropColumn(
                name: "MeterId1",
                table: "MeterLocations");

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "MeterLocations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations",
                columns: new[] { "MeterId", "LocationId", "ActiveDate" });

            migrationBuilder.AddForeignKey(
                name: "FK_MeterLocations_Locations_LocationId",
                table: "MeterLocations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeterLocations_Meters_MeterId",
                table: "MeterLocations",
                column: "MeterId",
                principalTable: "Meters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeterLocations_Locations_LocationId",
                table: "MeterLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_MeterLocations_Meters_MeterId",
                table: "MeterLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations");

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "MeterLocations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "MeterId1",
                table: "MeterLocations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations",
                column: "MeterId");

            migrationBuilder.CreateIndex(
                name: "IX_MeterLocations_MeterId1",
                table: "MeterLocations",
                column: "MeterId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MeterLocations_Locations_LocationId",
                table: "MeterLocations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MeterLocations_Meters_MeterId1",
                table: "MeterLocations",
                column: "MeterId1",
                principalTable: "Meters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
