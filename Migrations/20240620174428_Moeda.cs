using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investimento.Migrations
{
    /// <inheritdoc />
    public partial class Moeda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCompra",
                table: "TB_MOEDA");

            migrationBuilder.RenameColumn(
                name: "DataVenda",
                table: "TB_MOEDA",
                newName: "Data");

            migrationBuilder.AddColumn<int>(
                name: "Operacao",
                table: "TB_MOEDA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Data", "Operacao" },
                values: new object[] { new DateTime(2024, 6, 20, 17, 44, 27, 826, DateTimeKind.Local).AddTicks(7376), 2 });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Data", "Operacao" },
                values: new object[] { new DateTime(2024, 6, 20, 17, 44, 27, 826, DateTimeKind.Local).AddTicks(7462), 2 });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Data", "Operacao" },
                values: new object[] { new DateTime(2024, 6, 20, 17, 44, 27, 826, DateTimeKind.Local).AddTicks(7465), 2 });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Data", "Operacao" },
                values: new object[] { new DateTime(2024, 6, 20, 17, 44, 27, 826, DateTimeKind.Local).AddTicks(7467), 2 });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Data", "Operacao" },
                values: new object[] { new DateTime(2024, 6, 20, 17, 44, 27, 826, DateTimeKind.Local).AddTicks(7470), 2 });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Data", "Operacao" },
                values: new object[] { new DateTime(2024, 6, 20, 17, 44, 27, 826, DateTimeKind.Local).AddTicks(7471), 2 });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Data", "Operacao" },
                values: new object[] { new DateTime(2024, 6, 20, 17, 44, 27, 826, DateTimeKind.Local).AddTicks(7473), 2 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: new byte[] { 124, 106, 211, 254, 16, 161, 213, 99, 83, 100, 184, 129, 91, 252, 211, 73, 122, 63, 239, 215, 141, 61, 106, 195, 1, 193, 26, 248, 234, 78, 224, 58, 123, 145, 219, 91, 55, 240, 54, 192, 102, 11, 45, 33, 168, 50, 210, 94, 1, 184, 195, 150, 213, 175, 128, 68, 93, 213, 218, 230, 0, 208, 27, 30, 170, 148, 150, 87, 132, 93, 47, 233, 176, 205, 250, 100, 125, 55, 0, 30, 57, 3, 90, 130, 6, 182, 0, 65, 130, 38, 6, 126, 57, 51, 188, 215, 35, 100, 223, 246, 242, 133, 92, 30, 175, 7, 213, 236, 191, 235, 135, 22, 164, 54, 176, 202, 82, 6, 19, 95, 68, 207, 118, 27, 11, 66, 172, 186 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Operacao",
                table: "TB_MOEDA");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "TB_MOEDA",
                newName: "DataVenda");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCompra",
                table: "TB_MOEDA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2555), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2566), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2568), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2570), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2572), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2574), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "TB_MOEDA",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCompra", "DataVenda" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2576), new DateTime(2024, 6, 9, 0, 11, 10, 479, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: new byte[] { 131, 106, 246, 240, 74, 32, 121, 62, 146, 236, 176, 162, 219, 200, 127, 201, 56, 42, 178, 239, 63, 19, 205, 60, 99, 238, 14, 242, 221, 107, 52, 141, 166, 15, 193, 40, 34, 133, 59, 4, 65, 66, 225, 153, 21, 113, 185, 198, 106, 118, 36, 63, 7, 163, 205, 132, 186, 224, 160, 181, 89, 13, 5, 109, 185, 200, 140, 80, 102, 178, 97, 28, 214, 167, 27, 165, 5, 133, 231, 67, 124, 189, 202, 215, 207, 71, 252, 64, 198, 7, 32, 183, 171, 169, 23, 148, 171, 177, 185, 76, 223, 146, 137, 125, 207, 116, 161, 106, 176, 168, 82, 34, 81, 48, 143, 211, 71, 7, 35, 242, 17, 208, 242, 53, 161, 181, 28, 44 });
        }
    }
}
