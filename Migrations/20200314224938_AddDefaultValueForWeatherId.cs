using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace customer_consumption_api.Migrations
{
    public partial class AddDefaultValueForWeatherId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Weather",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Weather",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");
        }
    }
}
