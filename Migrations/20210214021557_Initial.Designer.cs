﻿// <auto-generated />
using APIElectron.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIElectron.Migrations
{
    [DbContext(typeof(SQLContext))]
    [Migration("20210214021557_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("APIElectron.Models.User", b =>
                {
                    b.Property<string>("idUser")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4");

                    b.HasKey("idUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MysqlC_.Models.Custumer", b =>
                {
                    b.Property<string>("idCustumer")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("name")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4");

                    b.Property<int>("phone")
                        .HasColumnType("int");

                    b.Property<int>("zip")
                        .HasColumnType("int");

                    b.HasKey("idCustumer");

                    b.ToTable("Custumers");
                });
#pragma warning restore 612, 618
        }
    }
}