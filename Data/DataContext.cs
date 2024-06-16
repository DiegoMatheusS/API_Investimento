using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investimento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using API_Investimento.Models;
using API_Investimento.Utils;

namespace Investimento.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) //cria o chamado para o banco de dados é o construtor
        {
            
        }

        public DbSet<Moeda> TB_MOEDA { get; set; }

        public DbSet<Usuario> TB_USUARIOS { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)// override serve para alterar
        {


            modelBuilder.Entity<Moeda>().ToTable("TB_MOEDA");
            modelBuilder.Entity<Usuario>().ToTable("TB_USUARIOS");



             modelBuilder.Entity<Moeda>().HasData
            (
                new Moeda() { Id = 1, Name = "BTC", Valor = 65000, Quantidade = 0.0050, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 250, Prejuizo=0, Imposto = 25.50 },
                new Moeda() { Id = 2, Name = "ETH", Valor = 3500, Quantidade= 0.020, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 125, Prejuizo=0, Imposto = 25.50},
                new Moeda() { Id = 3, Name = "SHIB", Valor = 0.00002437, Quantidade = 1123456.20, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 30, Prejuizo=0, Imposto = 25.50},
                new Moeda() { Id = 4, Name = "DOGE", Valor = 0.16, Quantidade= 124353.556, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 5, Prejuizo=0, Imposto = 25.50},
                new Moeda() { Id = 5, Name = "ADA", Valor = 0.4566, Quantidade = 1202.12, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 0, Prejuizo=50, Imposto = 25.50},
                new Moeda() { Id = 6, Name = "BNB", Valor = 500, Quantidade= 54, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 12, Prejuizo=0, Imposto = 25.50},
                new Moeda() { Id = 7, Name = "FLOKI", Valor = 0.00003565, Quantidade= 456543156.12, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 50, Prejuizo=0, Imposto = 25.50}
            );

            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[]hash, out byte[]salt);
            user.Id = 1;
            user.Username = "usuarioadmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordHash = salt;
            user.Perfil = "Admin";
            user.Email = "seuEmail@gamil.com";
            user.Latitude = -23.5200241;
            user.Longitude = -46.596498;

            modelBuilder.Entity<Usuario>().HasData(user);
            modelBuilder.Entity<Usuario>().Property(u => u.Perfil).HasDefaultValue("Insvetidor");
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)//convensao para configurar a base, regras
        {
            configurationBuilder.Properties<string>().HaveColumnType("Varchar").HaveMaxLength(200);
        }
    }
}
