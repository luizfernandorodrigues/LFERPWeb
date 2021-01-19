﻿// <auto-generated />
using System;
using LFERP.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LFERP.Data.Migrations
{
    [DbContext(typeof(ContextoBanco))]
    [Migration("20210119013103_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("LFERP.Negocio.Modelo.Cadastro.Logradouro.Cep", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoEnderecamentoPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdCidade")
                        .HasColumnType("UNIQUEIDENTIFIER");

                    b.HasKey("Id");

                    b.HasIndex("IdCidade");

                    b.ToTable("Ceps");
                });

            modelBuilder.Entity("LFERP.Negocio.Modelo.Cadastro.Logradouro.Cidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("UNIQUEIDENTIFIER")
                        .HasColumnName("Id");

                    b.Property<Guid>("IdEstado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(MAX)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.HasIndex("IdEstado");

                    b.ToTable("Cidade", "Cadastro");
                });

            modelBuilder.Entity("LFERP.Negocio.Modelo.Cadastro.Logradouro.Estado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid>("IdPais")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("Nome");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2)")
                        .HasColumnName("Sigla");

                    b.HasKey("Id")
                        .HasName("PK_Estado");

                    b.HasIndex("IdPais");

                    b.ToTable("Estado", "Cadastro");
                });

            modelBuilder.Entity("LFERP.Negocio.Modelo.Cadastro.Logradouro.Pais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Codigo")
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("Codigo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("Nome");

                    b.HasKey("Id")
                        .HasName("PK_Pais");

                    b.ToTable("Pais", "Cadastro");
                });

            modelBuilder.Entity("LFERP.Negocio.Modelo.Cadastro.Logradouro.Cep", b =>
                {
                    b.HasOne("LFERP.Negocio.Modelo.Cadastro.Logradouro.Cidade", "Cidade")
                        .WithMany("Ceps")
                        .HasForeignKey("IdCidade")
                        .HasConstraintName("FK_Cep_IdCidade")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("LFERP.Negocio.Modelo.Cadastro.Logradouro.Cidade", b =>
                {
                    b.HasOne("LFERP.Negocio.Modelo.Cadastro.Logradouro.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("IdEstado")
                        .HasConstraintName("FK_Cidade_IdEstado")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("LFERP.Negocio.Modelo.Cadastro.Logradouro.Estado", b =>
                {
                    b.HasOne("LFERP.Negocio.Modelo.Cadastro.Logradouro.Pais", "Pais")
                        .WithMany("Estados")
                        .HasForeignKey("IdPais")
                        .HasConstraintName("FK_Estado_IdPais")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("LFERP.Negocio.Modelo.Cadastro.Logradouro.Cidade", b =>
                {
                    b.Navigation("Ceps");
                });

            modelBuilder.Entity("LFERP.Negocio.Modelo.Cadastro.Logradouro.Estado", b =>
                {
                    b.Navigation("Cidades");
                });

            modelBuilder.Entity("LFERP.Negocio.Modelo.Cadastro.Logradouro.Pais", b =>
                {
                    b.Navigation("Estados");
                });
#pragma warning restore 612, 618
        }
    }
}