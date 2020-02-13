using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace customer_consumption_api.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    LocationClass = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meters",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    MeterType = table.Column<string>(nullable: true),
                    ServiceType = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    IntervalLength = table.Column<int>(nullable: false),
                    Channel1RawUom = table.Column<string>(nullable: true),
                    Channel2RawUom = table.Column<string>(nullable: true),
                    Channel3RawUom = table.Column<string>(nullable: true),
                    Channel4RawUom = table.Column<string>(nullable: true),
                    Channel5RawUom = table.Column<string>(nullable: true),
                    Channel6RawUom = table.Column<string>(nullable: true),
                    Channel7RawUom = table.Column<string>(nullable: true),
                    Channel8RawUom = table.Column<string>(nullable: true),
                    Channel1Multiplier = table.Column<string>(nullable: true),
                    Channel2Multiplier = table.Column<string>(nullable: true),
                    Channel3Multiplier = table.Column<string>(nullable: true),
                    Channel4Multiplier = table.Column<string>(nullable: true),
                    Channel5Multiplier = table.Column<string>(nullable: true),
                    Channel6Multiplier = table.Column<string>(nullable: true),
                    Channel7Multiplier = table.Column<string>(nullable: true),
                    Channel8Multiplier = table.Column<string>(nullable: true),
                    Channel1FinalUom = table.Column<string>(nullable: true),
                    Channel2FinalUom = table.Column<string>(nullable: true),
                    Channel3FinalUom = table.Column<string>(nullable: true),
                    Channel4FinalUom = table.Column<string>(nullable: true),
                    Channel5FinalUom = table.Column<string>(nullable: true),
                    Channel6FinalUom = table.Column<string>(nullable: true),
                    Channel7FinalUom = table.Column<string>(nullable: true),
                    Channel8FinalUom = table.Column<string>(nullable: true),
                    MeterCycle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLocations",
                columns: table => new
                {
                    CustomerId = table.Column<string>(nullable: false),
                    LocationId = table.Column<string>(nullable: true),
                    AccountLocationKey = table.Column<string>(nullable: true),
                    ServiceStart = table.Column<DateTime>(nullable: false),
                    ServiceEnd = table.Column<DateTime>(nullable: false),
                    CustomerId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLocations", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_CustomerLocations_Customers_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerLocations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeterIntervals",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MeterId = table.Column<string>(nullable: true),
                    ChannelId = table.Column<string>(nullable: true),
                    ReadDate = table.Column<DateTime>(nullable: false),
                    ReadHour = table.Column<int>(nullable: false),
                    Read30Min = table.Column<int>(nullable: false),
                    Read15Min = table.Column<int>(nullable: false),
                    Read5Min = table.Column<int>(nullable: false),
                    ReadDateTime = table.Column<DateTime>(nullable: false),
                    ReadValue = table.Column<decimal>(nullable: false),
                    Uom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterIntervals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeterIntervals_Meters_MeterId",
                        column: x => x.MeterId,
                        principalTable: "Meters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeterLocations",
                columns: table => new
                {
                    MeterId = table.Column<string>(nullable: false),
                    LocationId = table.Column<string>(nullable: true),
                    ActiveDate = table.Column<DateTime>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: false),
                    MeterId1 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterLocations", x => x.MeterId);
                    table.ForeignKey(
                        name: "FK_MeterLocations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeterLocations_Meters_MeterId1",
                        column: x => x.MeterId1,
                        principalTable: "Meters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLocations_CustomerId1",
                table: "CustomerLocations",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLocations_LocationId",
                table: "CustomerLocations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_MeterIntervals_MeterId",
                table: "MeterIntervals",
                column: "MeterId");

            migrationBuilder.CreateIndex(
                name: "IX_MeterLocations_LocationId",
                table: "MeterLocations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_MeterLocations_MeterId1",
                table: "MeterLocations",
                column: "MeterId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerLocations");

            migrationBuilder.DropTable(
                name: "MeterIntervals");

            migrationBuilder.DropTable(
                name: "MeterLocations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Meters");
        }
    }
}
