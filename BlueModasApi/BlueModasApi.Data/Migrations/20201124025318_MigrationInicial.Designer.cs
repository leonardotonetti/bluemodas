﻿// <auto-generated />
using BlueModasApi.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlueModasApi.Data.Migrations
{
    [DbContext(typeof(BlueModasApiContext))]
    [Migration("20201124025318_MigrationInicial")]
    partial class MigrationInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.HasSequence<int>("PedidoCodigo");

            modelBuilder.Entity("BlueModasApi.Business.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("BlueModasApi.Business.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("BlueModasApi.Business.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("PedidoCodigo")
                        .HasColumnType("int");

                    b.HasKey("PedidoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("BlueModasApi.Business.Models.PedidoItem", b =>
                {
                    b.Property<int>("PedidoItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(15,4)");

                    b.HasKey("PedidoItemId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("PedidoItem");
                });

            modelBuilder.Entity("BlueModasApi.Business.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TipoPublicoAlvoCategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("UrlImagem")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ProdutoId");

                    b.HasIndex("TipoPublicoAlvoCategoriaId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("BlueModasApi.Business.Models.TipoPublicoAlvo", b =>
                {
                    b.Property<int>("TipoPublicoAlvoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TipoPublicoAlvoId");

                    b.ToTable("TipoPublicoAlvo");
                });

            modelBuilder.Entity("BlueModasApi.Business.Models.TipoPublicoAlvoCategoria", b =>
                {
                    b.Property<int>("TipoPublicoAlvoCategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("TipoPublicoAlvoId")
                        .HasColumnType("int");

                    b.HasKey("TipoPublicoAlvoCategoriaId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("TipoPublicoAlvoId");

                    b.ToTable("TipoPublicoAlvoCategoria");
                });

            modelBuilder.Entity("BlueModasApi.Business.Models.Pedido", b =>
                {
                    b.HasOne("BlueModasApi.Business.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("BlueModasApi.Business.Models.PedidoItem", b =>
                {
                    b.HasOne("BlueModasApi.Business.Models.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueModasApi.Business.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("BlueModasApi.Business.Models.Produto", b =>
                {
                    b.HasOne("BlueModasApi.Business.Models.TipoPublicoAlvoCategoria", "TipoPublicoAlvoCategoria")
                        .WithMany()
                        .HasForeignKey("TipoPublicoAlvoCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoPublicoAlvoCategoria");
                });

            modelBuilder.Entity("BlueModasApi.Business.Models.TipoPublicoAlvoCategoria", b =>
                {
                    b.HasOne("BlueModasApi.Business.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueModasApi.Business.Models.TipoPublicoAlvo", "TipoPublicoAlvo")
                        .WithMany()
                        .HasForeignKey("TipoPublicoAlvoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("TipoPublicoAlvo");
                });
#pragma warning restore 612, 618
        }
    }
}
