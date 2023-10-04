using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RodFlix.Data.Migrations
{
    /// <inheritdoc />
    public partial class creating_a_imagem_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 1,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 2,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 3,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 4,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 5,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 6,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 7,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 8,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 9,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 10,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 11,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 12,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 13,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 14,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 15,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 16,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 17,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 18,
                column: "Img",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 19,
                column: "Img",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Movies");
        }
    }
}
