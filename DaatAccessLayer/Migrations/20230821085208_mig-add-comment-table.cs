using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DaatAccessLayer.Migrations
{
    public partial class migaddcommenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DestImage_Destinations_DestinationID",
                table: "DestImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DestImage",
                table: "DestImage");

            migrationBuilder.RenameTable(
                name: "DestImage",
                newName: "DestImages");

            migrationBuilder.RenameIndex(
                name: "IX_DestImage_DestinationID",
                table: "DestImages",
                newName: "IX_DestImages_DestinationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DestImages",
                table: "DestImages",
                column: "DestImageID");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentState = table.Column<bool>(type: "bit", nullable: false),
                    DestinationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Destinations_DestinationID",
                        column: x => x.DestinationID,
                        principalTable: "Destinations",
                        principalColumn: "DestinationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DestinationID",
                table: "Comments",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_DestImages_Destinations_DestinationID",
                table: "DestImages",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DestImages_Destinations_DestinationID",
                table: "DestImages");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DestImages",
                table: "DestImages");

            migrationBuilder.RenameTable(
                name: "DestImages",
                newName: "DestImage");

            migrationBuilder.RenameIndex(
                name: "IX_DestImages_DestinationID",
                table: "DestImage",
                newName: "IX_DestImage_DestinationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DestImage",
                table: "DestImage",
                column: "DestImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_DestImage_Destinations_DestinationID",
                table: "DestImage",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
