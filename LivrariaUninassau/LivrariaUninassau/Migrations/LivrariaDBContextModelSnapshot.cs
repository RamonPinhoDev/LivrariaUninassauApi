﻿// <auto-generated />
using System;
using LivrariaUninassau.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LivrariaUninassau.Migrations
{
    [DbContext(typeof(LivrariaDBContext))]
    partial class LivrariaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LivrariaUninassau.Models.EmprestimoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Editora")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int?>("ISBN")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.Property<string>("Idioma")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int?>("NumeroDePaginas")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("int");

                    b.Property<int?>("Quantidade")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTime?>("dataPublicação")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataUltimaAtualizacao")
                        .HasMaxLength(64)
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Emprestimo");
                });
#pragma warning restore 612, 618
        }
    }
}
