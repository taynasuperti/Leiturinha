using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leiturinha.Migrations
{
    /// <inheritdoc />
    public partial class AtualizarModeloAvaliacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacoes_Usuario_UsuarioId",
                table: "Avaliacoes");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "Avaliacoes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe82f5d5-fae9-40e8-b93f-2be5d2415119", "AQAAAAIAAYagAAAAEAnn5BbwkonPozqX+AGFSrcwOhHka/DDKsU7x1LYWumpvBidSQryP/pE7HeBxT75qg==", "05bfcf8f-452d-48d2-b66d-131692fb9a74" });

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacoes_Usuario_UsuarioId",
                table: "Avaliacoes",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacoes_Usuario_UsuarioId",
                table: "Avaliacoes");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "Avaliacoes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27c44aba-2182-4ac8-a13f-ce69a2f2aa84", "AQAAAAIAAYagAAAAED9m6wOc3A+Ngfl5j21Qj/RCOfrgeV5Vtd6UUUFZ+8QLvTSZApGWIKUhar5rL4prPg==", "416c56a7-d31d-441b-bc84-065ffff669d1" });

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacoes_Usuario_UsuarioId",
                table: "Avaliacoes",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
