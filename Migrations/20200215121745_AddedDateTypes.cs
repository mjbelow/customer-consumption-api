using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace customer_consumption_api.Migrations
{
    public partial class AddedDateTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InactiveDate",
                table: "MeterLocations",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ActiveDate",
                table: "MeterLocations",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReadDate",
                table: "MeterIntervals",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceStart",
                table: "CustomerLocations",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceEnd",
                table: "CustomerLocations",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations",
                columns: new[] { "MeterId", "LocationId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InactiveDate",
                table: "MeterLocations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ActiveDate",
                table: "MeterLocations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReadDate",
                table: "MeterIntervals",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceStart",
                table: "CustomerLocations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceEnd",
                table: "CustomerLocations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeterLocations",
                table: "MeterLocations",
                columns: new[] { "MeterId", "LocationId", "ActiveDate" });
        }
    }
}
