using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIOgVueAvslutning.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coockies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coockies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoockiesIngredients",
                columns: table => new
                {
                    CoockiesId = table.Column<int>(type: "INTEGER", nullable: false),
                    IngredientsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoockiesIngredients", x => new { x.CoockiesId, x.IngredientsId });
                    table.ForeignKey(
                        name: "FK_CoockiesIngredients_Coockies_CoockiesId",
                        column: x => x.CoockiesId,
                        principalTable: "Coockies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoockiesIngredients_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoockiesIngredients_IngredientsId",
                table: "CoockiesIngredients",
                column: "IngredientsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoockiesIngredients");

            migrationBuilder.DropTable(
                name: "Coockies");

            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
