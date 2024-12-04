using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelAPI.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoTabelaControleDeTrafego : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ControleDeTrafegos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControleDeTrafegos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControleDeTrafegoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voo_ControleDeTrafegos_ControleDeTrafegoId",
                        column: x => x.ControleDeTrafegoId,
                        principalTable: "ControleDeTrafegos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voo_ControleDeTrafegoId",
                table: "Voo",
                column: "ControleDeTrafegoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Voo");

            migrationBuilder.DropTable(
                name: "ControleDeTrafegos");
        }
    }
}
