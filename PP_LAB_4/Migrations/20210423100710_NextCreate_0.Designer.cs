﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PP_LAB_4.Data;

namespace PP_LAB_4.Migrations
{
    [DbContext(typeof(PP_LAB_4Context))]
    [Migration("20210423100710_NextCreate_0")]
    partial class NextCreate_0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PP_LAB_4.Models.currency", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("exchange")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("record_date")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("currency");
                });

            modelBuilder.Entity("PP_LAB_4.Models.przykladowa_klasa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DataWydania")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gatunek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platforma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tytuł")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("przykladowa_klasa");
                });
#pragma warning restore 612, 618
        }
    }
}