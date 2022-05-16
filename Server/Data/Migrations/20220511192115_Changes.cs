using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeDrivee.Server.Data.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserToken",
                table: "BookingModel");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BookingModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BookingModel");

            migrationBuilder.AddColumn<string>(
                name: "UserToken",
                table: "BookingModel",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
