using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketDetalle.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TicketDetalles",
                columns: table => new
                {
                    TicketDetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    emisor = table.Column<string>(type: "TEXT", nullable: false),
                    mensaje = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketDetalles", x => x.TicketDetalleId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketDetalles");
        }
    }
}
