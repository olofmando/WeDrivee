using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeDrivee.Server.Data.Migrations
{
    public partial class AddCars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookingModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingModel_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DailyPrice", "Name" },
                values: new object[] { 1, 300, "Volvo" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DailyPrice", "Name" },
                values: new object[] { 2, 200, "Saab" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DailyPrice", "Name" },
                values: new object[] { 3, 400, "Fiat" });

            migrationBuilder.CreateIndex(
                name: "IX_BookingModel_CarId",
                table: "BookingModel",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingModel");

            migrationBuilder.DropTable(
                name: "Cars");

         
        }
    }
}
