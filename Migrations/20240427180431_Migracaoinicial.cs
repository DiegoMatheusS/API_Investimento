using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Investimento.Migrations
{
    /// <inheritdoc />
    public partial class Migracaoinicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_MOEDA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    DataCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataVenda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lucro = table.Column<double>(type: "float", nullable: false),
                    Prejuizo = table.Column<double>(type: "float", nullable: false),
                    Imposto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_MOEDA", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_MOEDA",
                columns: new[] { "Id", "DataCompra", "DataVenda", "Imposto", "Lucro", "Name", "Prejuizo", "Quantidade", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(644), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(661), 25.5, 250.0, "BTC", 0.0, 0.0050000000000000001, 65000.0 },
                    { 2, new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(663), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(663), 25.5, 125.0, "ETH", 0.0, 0.02, 3500.0 },
                    { 3, new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(665), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(665), 25.5, 30.0, "SHIB", 0.0, 1123456.2, 2.4369999999999999E-05 },
                    { 4, new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(667), 25.5, 5.0, "DOGE", 0.0, 124353.556, 0.16 },
                    { 5, new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(669), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(669), 25.5, 0.0, "ADA", 50.0, 1202.1199999999999, 0.45660000000000001 },
                    { 6, new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(671), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(671), 25.5, 12.0, "BNB", 0.0, 54.0, 500.0 },
                    { 7, new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(673), new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(673), 25.5, 50.0, "FLOKI", 0.0, 456543156.12, 3.5649999999999999E-05 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_MOEDA");
        }
    }
}
