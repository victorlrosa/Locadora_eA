using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LocadoraApp.Models;

namespace LocadoraApp.Data
{
    public class LocadoraAppContext : DbContext
    {
        public LocadoraAppContext(DbContextOptions<LocadoraAppContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Locacao> Locacoes { get; set; }

        public DbSet<Filme> Filmes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(c => c.Nome)
                .HasMaxLength(200);

            modelBuilder.Entity<Cliente>()
                .Property(c => c.Cpf)
                .HasMaxLength(11);

            modelBuilder.Entity<Filme>()
                .Property(f => f.Titulo)
                .HasMaxLength(100);

        }
    }
}
