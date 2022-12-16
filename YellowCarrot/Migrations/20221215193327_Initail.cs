using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YellowCarrot.Migrations
{
    /// <inheritdoc />
    public partial class Initail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngridientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RecipeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngridientId);
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeTags",
                columns: table => new
                {
                    RecipesRecipeId = table.Column<int>(type: "int", nullable: false),
                    TagsName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeTags", x => new { x.RecipesRecipeId, x.TagsName });
                    table.ForeignKey(
                        name: "FK_RecipeTags_Recipes_RecipesRecipeId",
                        column: x => x.RecipesRecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeTags_Tags_TagsName",
                        column: x => x.TagsName,
                        principalTable: "Tags",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Name" },
                values: new object[] { 1, "Lasagna" });

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "Italian");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngridientId", "Name", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { 1, "Lasagna noodles", "9", 1 },
                    { 2, "Italian sausage", "450 g", 1 },
                    { 3, "Groud beef", "340 g", 1 },
                    { 4, "Onion", null, 1 },
                    { 5, "Garlic", "3 cloves", 1 },
                    { 6, "Crushed tomatoes", "2 can", 1 },
                    { 7, "Tomatoe paste", "2 cans", 1 },
                    { 8, "Parsley", "300 g", 1 },
                    { 9, "Basil", "2 teaspoons", 1 },
                    { 10, "Salt", "300 g", 1 },
                    { 11, "Egg", "1 lasge", 1 },
                    { 12, "Ricotta cheese", "1 carton", 1 },
                    { 13, "Mozzarella cheese", "4 cups", 1 },
                    { 14, "Parmesan cheese", "300 g", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeTags_TagsName",
                table: "RecipeTags",
                column: "TagsName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "RecipeTags");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
