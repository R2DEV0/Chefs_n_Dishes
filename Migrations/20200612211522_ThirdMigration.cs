using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chefs_n_Dishes.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Chefs",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Birthday",
                table: "Chefs",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
