using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DaatAccessLayer.Migrations
{
    public partial class migaddimagetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Destinations");

            migrationBuilder.CreateTable(
                name: "DestImage",
                columns: table => new
                {
                    DestImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ImageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DestinationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestImage", x => x.DestImageID);
                    table.ForeignKey(
                        name: "FK_DestImage_Destinations_DestinationID",
                        column: x => x.DestinationID,
                        principalTable: "Destinations",
                        principalColumn: "DestinationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DestImage_DestinationID",
                table: "DestImage",
                column: "DestinationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DestImage");

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
