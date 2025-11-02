using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leiturinha.Migrations
{
    /// <inheritdoc />
    public partial class Avaliacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd99c3a2-2f4e-407b-b8f2-9d06fe79c655", "AQAAAAIAAYagAAAAEIBiNWQ6aIl9idPlpGFy7sWnY7OMJZz3HsPpiv2LXrkM77oJegsMHm1kQ3hBRyu3Rg==", "921d9e27-62c8-4b1b-a4af-096805070181" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79cc9e8c-79bf-4711-8cb7-fc4c60f110af", "AQAAAAIAAYagAAAAELRjMBWMFU6JzQWBlZUwu1eNm0C4yjaCl2Js7nrWEq0FCRrysWaaTSiPclHcTDvITA==", "87331784-8b12-46b0-8899-f7d515bf8d2b" });
        }
    }
}
