// <auto-generated />
using System;
using LocadoraApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocadoraApp.Migrations
{
    [DbContext(typeof(LocadoraAppContext))]
    [Migration("20210926190013_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("LocadoraApp.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("LocadoraApp.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClassificacaoIndicativa")
                        .HasColumnType("int");

                    b.Property<int>("Lancamento")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("LocadoraApp.Models.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FilmeId");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("LocadoraApp.Models.Locacao", b =>
                {
                    b.HasOne("LocadoraApp.Models.Cliente", "Cliente")
                        .WithMany("Locacoes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocadoraApp.Models.Filme", "Filme")
                        .WithMany("Locacoes")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("LocadoraApp.Models.Cliente", b =>
                {
                    b.Navigation("Locacoes");
                });

            modelBuilder.Entity("LocadoraApp.Models.Filme", b =>
                {
                    b.Navigation("Locacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
