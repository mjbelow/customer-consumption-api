using Microsoft.EntityFrameworkCore.Migrations;

namespace customer_consumption_api.Migrations
{
    public partial class AddIncrementalIdForCustomerLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CustomerLocations",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "CustomerLocations");
        }
    }
}
