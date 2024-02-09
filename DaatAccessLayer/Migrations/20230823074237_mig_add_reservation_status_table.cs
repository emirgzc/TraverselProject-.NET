using Microsoft.EntityFrameworkCore.Migrations;

namespace DaatAccessLayer.Migrations
{
    public partial class mig_add_reservation_status_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReserStatusID",
                table: "Reservations",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ReserStatus",
                columns: table => new
                {
                    ReserStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReserStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserStatus", x => x.ReserStatusID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReserStatusID",
                table: "Reservations",
                column: "ReserStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ReserStatus_ReserStatusID",
                table: "Reservations",
                column: "ReserStatusID",
                principalTable: "ReserStatus",
                principalColumn: "ReserStatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ReserStatus_ReserStatusID",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "ReserStatus");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReserStatusID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReserStatusID",
                table: "Reservations");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
