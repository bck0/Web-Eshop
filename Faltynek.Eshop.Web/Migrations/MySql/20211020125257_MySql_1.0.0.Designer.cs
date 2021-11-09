﻿// <auto-generated />
using Faltynek.Eshop.Web.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Faltynek.Eshop.Web.Migrations.MySql
{
    [DbContext(typeof(EshopDbContext))]
    [Migration("20211020125257_MySql_1.0.0")]
    partial class MySql_100
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Faltynek.Eshop.Web.Models.Entity.CarouselItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageAlt")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ImageSource")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.ToTable("CarouselItem");
                });
#pragma warning restore 612, 618
        }
    }
}
