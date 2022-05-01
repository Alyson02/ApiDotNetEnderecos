﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteSamuel.Data;

namespace TesteSamuel.Migrations
{
    [DbContext(typeof(EnderecoContext))]
    partial class EnderecoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TesteSamuel.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cep")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Rua")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}