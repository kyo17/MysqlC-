﻿// <auto-generated />
using APIElectron.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIElectron.Migrations
{
    [DbContext(typeof(SQLContext))]
    [Migration("20210214002911_Users")]
    partial class Users
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
#pragma warning restore 612, 618
        }
    }
}
