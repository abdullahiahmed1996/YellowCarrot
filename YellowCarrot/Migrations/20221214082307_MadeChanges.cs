using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YellowCarrot.Migrations
{
    /// <inheritdoc />
    public partial class MadeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Tags_TagsTagId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_TagsTagId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TagsTagId",
                table: "Recipes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Name");

            migrationBuilder.CreateTable(
                name: "RecipeTags",
                columns: table => new
                {
                    RecipesRecipeId = table.Column<int>(type: "int", nullable: false),
                    TagsName = table.Column<string>(type: "nvarchar(450)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_RecipeTags_TagsName",
                table: "RecipeTags",
                column: "TagsName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Tags",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagsTagId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_TagsTagId",
                table: "Recipes",
                column: "TagsTagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Tags_TagsTagId",
                table: "Recipes",
                column: "TagsTagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
