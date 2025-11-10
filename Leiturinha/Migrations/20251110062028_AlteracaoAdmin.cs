using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leiturinha.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TextoComentario",
                table: "Comentarios",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "DataCadastro", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51f989ee-67f5-40e0-98de-7f7a88fb3e68", new DateTime(2025, 11, 10, 3, 20, 24, 826, DateTimeKind.Local).AddTicks(126), "AQAAAAIAAYagAAAAEIccOE7JWQAACJtT2/qruoGW5tlU9niYD7uUlrNtJNE/WylLEfnhNcD4PYVn65ut7g==", "c9e185f7-ceb5-4f70-808e-059ec8ced80e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TextoComentario",
                table: "Comentarios",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 5000);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "DataCadastro", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0041f3fb-9d5d-4cb6-a779-bff4c257912b", new DateTime(2025, 11, 10, 1, 57, 12, 707, DateTimeKind.Local).AddTicks(5470), "AQAAAAIAAYagAAAAEESMxFWIhZq65LyEI4hgDkP9Vubl+8mDhRIMv8hoElVdLnoOfuchg/F/N156lqkwLw==", "4a4e8066-d923-4a69-a754-c7e1a50b7013" });
        }
    }
}
