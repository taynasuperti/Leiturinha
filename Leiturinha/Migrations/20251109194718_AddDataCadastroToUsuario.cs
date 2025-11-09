using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leiturinha.Migrations
{
    /// <inheritdoc />
    public partial class AddDataCadastroToUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "DataCadastro", "PasswordHash", "SecurityStamp" },
                values: new object[] { "606dd83f-2c1a-44c5-9d4a-e203753e0fb7", new DateTime(2025, 11, 9, 16, 47, 14, 925, DateTimeKind.Local).AddTicks(6268), "AQAAAAIAAYagAAAAEPr21K29hORGXmrpkUcqeGRQNQQao8guEJrdMHkIUNxYf7E572Aa2Xo6JezsCTKMeQ==", "d8c053f2-92f2-4cd2-9f69-2a7a69a32d95" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d5b9eb1-a814-49c8-8443-9aaecbba9a1a", "AQAAAAIAAYagAAAAEAe6j1qpoUF1DskOFslNa0HM8o5mc5DnfxrH72R7rMGWxXmtA/+78KBA9GDzZcV+LQ==", "cf8e89dc-2c23-425a-88d7-e6e2d62a4e79" });
        }
    }
}
