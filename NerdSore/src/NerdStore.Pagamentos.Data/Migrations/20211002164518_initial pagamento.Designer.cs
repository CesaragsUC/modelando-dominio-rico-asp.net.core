﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NerdStore.Pagamentos.Data;

namespace NerdStore.Pagamentos.Data.Migrations
{
    [DbContext(typeof(PagamentoContext))]
    [Migration("20211002164518_initial pagamento")]
    partial class initialpagamento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NerdStore.Pagamentos.Business.Entities.Pagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CvvCartao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ExpiracaoCartao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NomeCartao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NumeroCartao")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("NerdStore.Pagamentos.Business.Entities.Transacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PagamentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StatusTransacao")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("PagamentoId")
                        .IsUnique();

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("NerdStore.Pagamentos.Business.Entities.Transacao", b =>
                {
                    b.HasOne("NerdStore.Pagamentos.Business.Entities.Pagamento", "Pagamento")
                        .WithOne("Transacao")
                        .HasForeignKey("NerdStore.Pagamentos.Business.Entities.Transacao", "PagamentoId")
                        .IsRequired();

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("NerdStore.Pagamentos.Business.Entities.Pagamento", b =>
                {
                    b.Navigation("Transacao");
                });
#pragma warning restore 612, 618
        }
    }
}
