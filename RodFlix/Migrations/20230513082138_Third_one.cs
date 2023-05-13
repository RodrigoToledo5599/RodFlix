using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RodFlix.Migrations
{
    /// <inheritdoc />
    public partial class Third_one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "IdAccount", "Email", "Senha" },
                values: new object[] { 2, "emailgenerico@gmail.com", "senha123" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: 2);
        }
    }
}
