﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Investimento.Data;

#nullable disable

namespace Investimento.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240427180431_Migracaoinicial")]
    partial class Migracaoinicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Investimento.Models.Enuns.Moeda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<double>("Imposto")
                        .HasColumnType("float");

                    b.Property<double>("Lucro")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prejuizo")
                        .HasColumnType("float");

                    b.Property<double>("Quantidade")
                        .HasColumnType("float");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("TB_MOEDA", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataCompra = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(644),
                            DataVenda = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(661),
                            Imposto = 25.5,
                            Lucro = 250.0,
                            Name = "BTC",
                            Prejuizo = 0.0,
                            Quantidade = 0.0050000000000000001,
                            Valor = 65000.0
                        },
                        new
                        {
                            Id = 2,
                            DataCompra = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(663),
                            DataVenda = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(663),
                            Imposto = 25.5,
                            Lucro = 125.0,
                            Name = "ETH",
                            Prejuizo = 0.0,
                            Quantidade = 0.02,
                            Valor = 3500.0
                        },
                        new
                        {
                            Id = 3,
                            DataCompra = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(665),
                            DataVenda = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(665),
                            Imposto = 25.5,
                            Lucro = 30.0,
                            Name = "SHIB",
                            Prejuizo = 0.0,
                            Quantidade = 1123456.2,
                            Valor = 2.4369999999999999E-05
                        },
                        new
                        {
                            Id = 4,
                            DataCompra = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(667),
                            DataVenda = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(667),
                            Imposto = 25.5,
                            Lucro = 5.0,
                            Name = "DOGE",
                            Prejuizo = 0.0,
                            Quantidade = 124353.556,
                            Valor = 0.16
                        },
                        new
                        {
                            Id = 5,
                            DataCompra = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(669),
                            DataVenda = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(669),
                            Imposto = 25.5,
                            Lucro = 0.0,
                            Name = "ADA",
                            Prejuizo = 50.0,
                            Quantidade = 1202.1199999999999,
                            Valor = 0.45660000000000001
                        },
                        new
                        {
                            Id = 6,
                            DataCompra = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(671),
                            DataVenda = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(671),
                            Imposto = 25.5,
                            Lucro = 12.0,
                            Name = "BNB",
                            Prejuizo = 0.0,
                            Quantidade = 54.0,
                            Valor = 500.0
                        },
                        new
                        {
                            Id = 7,
                            DataCompra = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(673),
                            DataVenda = new DateTime(2024, 4, 27, 15, 4, 31, 74, DateTimeKind.Local).AddTicks(673),
                            Imposto = 25.5,
                            Lucro = 50.0,
                            Name = "FLOKI",
                            Prejuizo = 0.0,
                            Quantidade = 456543156.12,
                            Valor = 3.5649999999999999E-05
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
