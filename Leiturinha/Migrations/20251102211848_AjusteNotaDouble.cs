using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leiturinha.Migrations
{
    /// <inheritdoc />
    public partial class AjusteNotaDouble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Nota",
                table: "Avaliacoes",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27c44aba-2182-4ac8-a13f-ce69a2f2aa84", "AQAAAAIAAYagAAAAED9m6wOc3A+Ngfl5j21Qj/RCOfrgeV5Vtd6UUUFZ+8QLvTSZApGWIKUhar5rL4prPg==", "416c56a7-d31d-441b-bc84-065ffff669d1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Nota",
                table: "Avaliacoes",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd99c3a2-2f4e-407b-b8f2-9d06fe79c655", "AQAAAAIAAYagAAAAEIBiNWQ6aIl9idPlpGFy7sWnY7OMJZz3HsPpiv2LXrkM77oJegsMHm1kQ3hBRyu3Rg==", "921d9e27-62c8-4b1b-a4af-096805070181" });
        }
    }
}
