using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leiturinha.Migrations
{
    /// <inheritdoc />
    public partial class AddMaxLengthComentario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "DataCadastro", "Foto", "Nome", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0041f3fb-9d5d-4cb6-a779-bff4c257912b", new DateTime(2025, 11, 10, 1, 57, 12, 707, DateTimeKind.Local).AddTicks(5470), "/img/usuarios/admin.jpg", "Tayná Superti", "AQAAAAIAAYagAAAAEESMxFWIhZq65LyEI4hgDkP9Vubl+8mDhRIMv8hoElVdLnoOfuchg/F/N156lqkwLw==", "4a4e8066-d923-4a69-a754-c7e1a50b7013" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "DataCadastro", "Foto", "Nome", "PasswordHash", "SecurityStamp" },
                values: new object[] { "606dd83f-2c1a-44c5-9d4a-e203753e0fb7", new DateTime(2025, 11, 9, 16, 47, 14, 925, DateTimeKind.Local).AddTicks(6268), "/img/usuarios/no-photo.jpg", "Tayná Carolina Miguel Superti", "AQAAAAIAAYagAAAAEPr21K29hORGXmrpkUcqeGRQNQQao8guEJrdMHkIUNxYf7E572Aa2Xo6JezsCTKMeQ==", "d8c053f2-92f2-4cd2-9f69-2a7a69a32d95" });
        }
    }
}
