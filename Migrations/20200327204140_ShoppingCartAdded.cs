using Microsoft.EntityFrameworkCore.Migrations;

namespace csc237_gtanaka_Bethanys.Migrations
{
    public partial class ShoppingCartAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PieID = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemID);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Pies_PieID",
                        column: x => x.PieID,
                        principalTable: "Pies",
                        principalColumn: "PieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_PieID",
                table: "ShoppingCartItems",
                column: "PieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");
        }
    }
}
