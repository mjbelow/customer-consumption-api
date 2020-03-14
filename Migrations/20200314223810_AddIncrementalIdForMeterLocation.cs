using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace customer_consumption_api.Migrations
{
    public partial class AddIncrementalIdForMeterLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MeterLocations",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StationId = table.Column<string>(nullable: true),
                    DataTypeId = table.Column<string>(nullable: true),
                    ReadDate = table.Column<DateTime>(type: "Date", nullable: false),
                    ReadHour = table.Column<int>(nullable: false),
                    ReadDateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false),
                    Uom = table.Column<string>(nullable: true),
                    AlphaValue = table.Column<string>(nullable: true),
                    QualityCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MeterLocations");
        }
    }
}
