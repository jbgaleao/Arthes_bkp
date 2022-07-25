﻿// <auto-generated />
using Arthes.DATA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Arthes.DATA.Migrations
{
    [DbContext(typeof(ArthesContext))]
    [Migration("20220725005455_RelacionamentoRevistaReceira")]
    partial class RelacionamentoRevistaReceira
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Arthes.DATA.Models.ModelReceita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Altura")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Dificuldade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RevistaId")
                        .HasColumnType("int");

                    b.Property<int>("_ModelRevistaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("_ModelRevistaId");

                    b.ToTable("RECEITAS");
                });

            modelBuilder.Entity("Arthes.DATA.Models.ModelRevista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnoEdicao")
                        .HasColumnType("int");

                    b.Property<int>("MesEdicao")
                        .HasColumnType("int");

                    b.Property<int>("NumeroEdicao")
                        .HasColumnType("int");

                    b.Property<string>("Tema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("REVISTAS");
                });

            modelBuilder.Entity("Arthes.DATA.Models.ModelReceita", b =>
                {
                    b.HasOne("Arthes.DATA.Models.ModelRevista", "_ModelRevista")
                        .WithMany("ListaReceita")
                        .HasForeignKey("_ModelRevistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_ModelRevista");
                });

            modelBuilder.Entity("Arthes.DATA.Models.ModelRevista", b =>
                {
                    b.Navigation("ListaReceita");
                });
#pragma warning restore 612, 618
        }
    }
}