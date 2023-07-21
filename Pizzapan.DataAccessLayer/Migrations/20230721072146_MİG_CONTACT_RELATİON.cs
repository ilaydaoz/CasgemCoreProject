using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzapan.DataAccessLayer.Migrations
{
    public partial class MİG_CONTACT_RELATİON : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpeningClosingTime",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "OpeningHours",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpeningHours",
                table: "Contacts");

            migrationBuilder.AddColumn<DateTime>(
                name: "OpeningClosingTime",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
