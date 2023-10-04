using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RodFlix.Data.Migrations
{
    /// <inheritdoc />
    public partial class adding_a_movie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    IdAccount = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.IdAccount);
                });

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
                table: "Account",
                columns: new[] { "IdAccount", "Email", "Senha" },
                values: new object[,]
                {
                    { 1, "123@gmail.com", "123" },
                    { 2, "emailgenerico@gmail.com", "senha123" }
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
                    { (byte)11, "Romance" },
                    { (byte)12, "Zombie" },
                    { (byte)13, "Comédia" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "IdMovie", "Categoria1", "Categoria2", "Categoria3", "Categoria4", "Categoria5", "Categoria6", "Description", "LengthMinutes", "Title" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, 103, "Carga Explosiva" },
                    { 2, null, null, null, null, null, null, null, 99, "Sonic o filme" },
                    { 3, null, null, null, null, null, null, null, 130, "Exterminador do futuro" },
                    { 4, null, null, null, null, null, null, null, 100, "One piece film red" },
                    { 5, null, null, null, null, null, null, null, 140, "Avatar" },
                    { 6, null, null, null, null, null, null, null, 96, "Debi e Loide 2" },
                    { 7, null, null, null, null, null, null, null, 90, "Zohan" },
                    { 8, null, null, null, null, null, null, null, 180, "Senhor dos anéis 2" },
                    { 9, null, null, null, null, null, null, null, 103, "Drive" },
                    { 10, null, null, null, null, null, null, null, 110, "Taxi Driver" },
                    { 11, null, null, null, null, null, null, null, 160, "Blade runner o caçador de androides" },
                    { 12, null, null, null, null, null, null, null, 132, "Homem aranha 2" },
                    { 13, null, null, null, null, null, null, null, 105, "Iron man" },
                    { 14, null, null, null, null, null, null, null, 103, "Velozes e furiosos" },
                    { 15, null, null, null, null, null, null, null, 100, "Rocky" },
                    { 16, null, null, null, null, null, null, null, 90, "Rambo the first blood" },
                    { 17, null, null, null, null, null, null, null, 125, "Transformers" },
                    { 18, null, null, null, null, null, null, null, 98, "Carga Explosiva 2" },
                    { 19, null, null, null, null, null, null, null, 99, "Kung Fu Panda 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "DmCategories");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
