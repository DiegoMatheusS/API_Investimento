using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investimento.Migrations
{
    /// <inheritdoc />
    public partial class Usuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TB_MOEDA",
                type: "Varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TB_MOEDA",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "Varchar(200)", maxLength: 200, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Perfil = table.Column<string>(type: "Varchar(200)", maxLength: 200, nullable: false, defaultValue: "Insvetidor"),
                    Email = table.Column<string>(type: "Varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCompra", "DataVenda", "UsuarioId" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2555), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2564), null });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCompra", "DataVenda", "UsuarioId" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2566), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2566), null });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCompra", "DataVenda", "UsuarioId" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2568), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2569), null });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCompra", "DataVenda", "UsuarioId" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2570), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2571), null });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCompra", "DataVenda", "UsuarioId" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2572), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2573), null });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCompra", "DataVenda", "UsuarioId" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2574), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2574), null });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCompra", "DataVenda", "UsuarioId" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2576), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2576), null });

            migrationBuilder.InsertData(
                table: "TB_USUARIOS",
                columns: new[] { "Id", "DataAcesso", "Email", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Perfil", "Username" },
                values: new object[] { 1, null, "seuEmail@gamil.com", null, -23.520024100000001, -46.596497999999997, new byte[] { 131, 106, 246, 240, 74, 32, 121, 62, 146, 236, 176, 162, 219, 200, 127, 201, 56, 42, 178, 239, 63, 19, 205, 60, 99, 238, 14, 242, 221, 107, 52, 141, 166, 15, 193, 40, 34, 133, 59, 4, 65, 66, 225, 153, 21, 113, 185, 198, 106, 118, 36, 63, 7, 163, 205, 132, 186, 224, 160, 181, 89, 13, 5, 109, 185, 200, 140, 80, 102, 178, 97, 28, 214, 167, 27, 165, 5, 133, 231, 67, 124, 189, 202, 215, 207, 71, 252, 64, 198, 7, 32, 183, 171, 169, 23, 148, 171, 177, 185, 76, 223, 146, 137, 125, 207, 116, 161, 106, 176, 168, 82, 34, 81, 48, 143, 211, 71, 7, 35, 242, 17, 208, 242, 53, 161, 181, 28, 44 }, null, "Admin", "usuarioadmin" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_MOEDA_UsuarioId",
                table: "TB_MOEDA",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_MOEDA_TB_USUARIOS_UsuarioId",
                table: "TB_MOEDA",
                column: "UsuarioId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_MOEDA_TB_USUARIOS_UsuarioId",
                table: "TB_MOEDA");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS");

            migrationBuilder.DropIndex(
                name: "IX_TB_MOEDA_UsuarioId",
                table: "TB_MOEDA");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TB_MOEDA");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TB_MOEDA",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(644), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(663), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(665), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(669), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(671), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(673), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(673) });
        }
    }
}
