﻿// <auto-generated />
using System;
using EF_ReverseEngineer_and_CodeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_ReverseEngineer_and_CodeFirst.Migrations
{
    [DbContext(typeof(ExistingContextDb))]
    [Migration("20220812130832_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF_ReverseEngineer_and_CodeFirst.Bike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Garantia")
                        .HasColumnType("bit");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Bikes");
                });

            modelBuilder.Entity("EF_ReverseEngineer_and_CodeFirst.Inspections", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comments")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("InspectionTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "InspectionTypeId" }, "IX_Inspections_InspectionTypeId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("EF_ReverseEngineer_and_CodeFirst.InspectionTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("InspectionName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("InspectionTypes");
                });

            modelBuilder.Entity("EF_ReverseEngineer_and_CodeFirst.Statuses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("StatusOption")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("EF_ReverseEngineer_and_CodeFirst.Inspections", b =>
                {
                    b.HasOne("EF_ReverseEngineer_and_CodeFirst.InspectionTypes", "InspectionType")
                        .WithMany("Inspections")
                        .HasForeignKey("InspectionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InspectionType");
                });

            modelBuilder.Entity("EF_ReverseEngineer_and_CodeFirst.InspectionTypes", b =>
                {
                    b.Navigation("Inspections");
                });
#pragma warning restore 612, 618
        }
    }
}
