﻿// <auto-generated />
using System;
using Facec.Repositorio.nsContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Facec.Repositorio.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("Facec.Dominio.nsEntidades.Cliente", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)")
                        .HasColumnName("ID");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("DS_DOCUMENTO");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("DS_NOME");

                    b.HasKey("Id");

                    b.ToTable("CLIENTE");
                });
#pragma warning restore 612, 618
        }
    }
}