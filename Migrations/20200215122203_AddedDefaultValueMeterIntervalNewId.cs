using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace customer_consumption_api.Migrations
{
    public partial class AddedDefaultValueMeterIntervalNewId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "MeterIntervals",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations",
                columns: new[] { "MeterId", "LocationId", "ActiveDate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "MeterIntervals",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations",
                columns: new[] { "MeterId", "LocationId" });
        }
    }
}
