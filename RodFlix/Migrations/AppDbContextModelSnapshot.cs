﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RodFlix.Data;

#nullable disable

namespace RodFlix.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RodFlix.Models.Account", b =>
                {
                    b.Property<int>("IdAccount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAccount"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.HasKey("IdAccount");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            IdAccount = 1,
                            Email = "123@gmail.com",
                            Senha = "123"
                        });
                });

            modelBuilder.Entity("RodFlix.Models.DmCategories", b =>
                {
                    b.Property<byte>("IdDmCategories")
                        .HasColumnType("tinyint");

                    b.Property<string>("CategorieName")
                        .IsRequired()
                        .HasMaxLength(63)
                        .HasColumnType("nvarchar(63)");

                    b.HasKey("IdDmCategories");

                    b.ToTable("DmCategories");

                    b.HasData(
                        new
                        {
                            IdDmCategories = (byte)1,
                            CategorieName = "Ação"
                        },
                        new
                        {
                            IdDmCategories = (byte)2,
                            CategorieName = "Drama"
                        },
                        new
                        {
                            IdDmCategories = (byte)3,
                            CategorieName = "Terror"
                        },
                        new
                        {
                            IdDmCategories = (byte)4,
                            CategorieName = "Horror"
                        },
                        new
                        {
                            IdDmCategories = (byte)5,
                            CategorieName = "Infantil"
                        },
                        new
                        {
                            IdDmCategories = (byte)6,
                            CategorieName = "Aventura"
                        },
                        new
                        {
                            IdDmCategories = (byte)7,
                            CategorieName = "Carros"
                        },
                        new
                        {
                            IdDmCategories = (byte)8,
                            CategorieName = "Documentario"
                        },
                        new
                        {
                            IdDmCategories = (byte)9,
                            CategorieName = "Anime"
                        },
                        new
                        {
                            IdDmCategories = (byte)10,
                            CategorieName = "80s"
                        },
                        new
                        {
                            IdDmCategories = (byte)11,
                            CategorieName = "Romance"
                        },
                        new
                        {
                            IdDmCategories = (byte)12,
                            CategorieName = "Zombie"
                        },
                        new
                        {
                            IdDmCategories = (byte)13,
                            CategorieName = "Comédia"
                        });
                });

            modelBuilder.Entity("RodFlix.Models.Movies", b =>
                {
                    b.Property<int>("IdMovie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMovie"));

                    b.Property<byte?>("Categoria1")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Categoria2")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Categoria3")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Categoria4")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Categoria5")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Categoria6")
                        .HasColumnType("tinyint");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("LengthMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMovie");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            IdMovie = 1,
                            LengthMinutes = 0,
                            Title = "Carga Explosiva"
                        },
                        new
                        {
                            IdMovie = 2,
                            LengthMinutes = 0,
                            Title = "Sonic o filme"
                        },
                        new
                        {
                            IdMovie = 3,
                            LengthMinutes = 0,
                            Title = "Exterminador do futuro"
                        },
                        new
                        {
                            IdMovie = 4,
                            LengthMinutes = 0,
                            Title = "One piece film red"
                        },
                        new
                        {
                            IdMovie = 5,
                            LengthMinutes = 0,
                            Title = "Avatar"
                        },
                        new
                        {
                            IdMovie = 6,
                            LengthMinutes = 0,
                            Title = "Debi e Loide 2"
                        },
                        new
                        {
                            IdMovie = 7,
                            LengthMinutes = 0,
                            Title = "Zohan"
                        },
                        new
                        {
                            IdMovie = 8,
                            LengthMinutes = 0,
                            Title = "Senhor dos anéis 2"
                        },
                        new
                        {
                            IdMovie = 9,
                            LengthMinutes = 0,
                            Title = "Drive"
                        },
                        new
                        {
                            IdMovie = 10,
                            LengthMinutes = 0,
                            Title = "Taxi Driver"
                        },
                        new
                        {
                            IdMovie = 11,
                            LengthMinutes = 0,
                            Title = "Blade runner o caçador de androides"
                        },
                        new
                        {
                            IdMovie = 12,
                            LengthMinutes = 0,
                            Title = "Homem aranha 2"
                        },
                        new
                        {
                            IdMovie = 13,
                            LengthMinutes = 0,
                            Title = "Iron man"
                        },
                        new
                        {
                            IdMovie = 14,
                            LengthMinutes = 0,
                            Title = "Velozes e furiosos"
                        },
                        new
                        {
                            IdMovie = 15,
                            LengthMinutes = 0,
                            Title = "Rocky"
                        },
                        new
                        {
                            IdMovie = 16,
                            LengthMinutes = 0,
                            Title = "Rambo the first blood"
                        },
                        new
                        {
                            IdMovie = 17,
                            LengthMinutes = 0,
                            Title = "Transformers"
                        },
                        new
                        {
                            IdMovie = 18,
                            LengthMinutes = 0,
                            Title = "Carga Explosiva 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
