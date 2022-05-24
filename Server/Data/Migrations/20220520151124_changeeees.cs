using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeDrivee.Server.Data.Migrations
{
    public partial class changeeees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingModel_Cars_CarId",
                table: "BookingModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingModel",
                table: "BookingModel");

            migrationBuilder.RenameTable(
                name: "BookingModel",
                newName: "Bookings");

            migrationBuilder.RenameIndex(
                name: "IX_BookingModel_CarId",
                table: "Bookings",
                newName: "IX_Bookings_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Cars_CarId",
                table: "Bookings",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Cars_CarId",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "BookingModel");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_CarId",
                table: "BookingModel",
                newName: "IX_BookingModel_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingModel",
                table: "BookingModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingModel_Cars_CarId",
                table: "BookingModel",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
