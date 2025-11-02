using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leiturinha.Migrations
{
    /// <inheritdoc />
    public partial class AddAvaliacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79cc9e8c-79bf-4711-8cb7-fc4c60f110af", "AQAAAAIAAYagAAAAELRjMBWMFU6JzQWBlZUwu1eNm0C4yjaCl2Js7nrWEq0FCRrysWaaTSiPclHcTDvITA==", "87331784-8b12-46b0-8899-f7d515bf8d2b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e21868fa-b0ca-4f0c-9ea0-95e95874b5ad", "AQAAAAIAAYagAAAAEGys3FRV88ZqFMQ7QN8KmbvpIn9nIXWFhJl3I+aFoKtKOrcoNePXrRObxDx48Z59JA==", "251d4433-e6db-411f-8b34-aacbb95ebd46" });
        }
    }
}
