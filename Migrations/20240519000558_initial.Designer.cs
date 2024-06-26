﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using OrderAI_Dotnet.Data;

#nullable disable

namespace OrderAI_Dotnet.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240519000558_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrderAI_Dotnet.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataEntrega")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<double>("FreteEntrega")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("BINARY_DOUBLE");

                    b.HasKey("Id");

                    b.ToTable("TabelaPedido");
                });

            modelBuilder.Entity("OrderAI_Dotnet.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("dataCadastro")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("dataNascimento")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("sexo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("TabelaUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
