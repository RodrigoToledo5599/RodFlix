using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RodFlix.Migrations
{
    /// <inheritdoc />
    public partial class FirstOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DmCategories",
                columns: table => new
                {
                    IdDmCategories = table.Column<byte>(type: "tinyint", nullable: false),
                    CategorieName = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DmCategories", x => x.IdDmCategories);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    IdMovie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LengthMinutes = table.Column<int>(type: "int", nullable: false),
                    Categoria1 = table.Column<byte>(type: "tinyint", nullable: true),
                    Categoria2 = table.Column<byte>(type: "tinyint", nullable: true),
                    Categoria3 = table.Column<byte>(type: "tinyint", nullable: true),
                    Categoria4 = table.Column<byte>(type: "tinyint", nullable: true),
                    Categoria5 = table.Column<byte>(type: "tinyint", nullable: true),
                    Categoria6 = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.IdMovie);
                });

            migrationBuilder.InsertData(
                table: "DmCategories",
                columns: new[] { "IdDmCategories", "CategorieName" },
                values: new object[,]
                {
                    { (byte)1, "Ação" },
                    { (byte)2, "Drama" },
                    { (byte)3, "Terror" },
                    { (byte)4, "Horror" },
                    { (byte)5, "Infantil" },
                    { (byte)6, "Aventura" },
                    { (byte)7, "Carros" },
                    { (byte)8, "Documentario" },
                    { (byte)9, "Anime" },
                    { (byte)10, "80s" },
                    { (byte)11, "Romance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DmCategories");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
