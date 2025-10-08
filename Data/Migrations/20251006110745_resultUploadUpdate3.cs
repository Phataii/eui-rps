using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rps.Data.Migrations
{
    public partial class resultUploadUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentSessionToken",
                table: "ResultAccesses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUsed",
                table: "ResultAccesses",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SessionExpiry",
                table: "ResultAccesses",
                type: "datetime(6)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentSessionToken",
                table: "ResultAccesses");

            migrationBuilder.DropColumn(
                name: "LastUsed",
                table: "ResultAccesses");

            migrationBuilder.DropColumn(
                name: "SessionExpiry",
                table: "ResultAccesses");
        }
    }
}
