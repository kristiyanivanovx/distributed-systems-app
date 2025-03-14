﻿// <auto-generated />
using System;
using FM.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FM.Data.Migrations
{
    [DbContext(typeof(FootballManagerDbContext))]
    [Migration("20250309192746_ExtendedModels")]
    partial class ExtendedModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FM.Data.Entities.Athlete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("MarketValue")
                        .HasColumnType("decimal(19, 2)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Athletes");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Cristiano",
                            IsActive = true,
                            LastName = "Ronaldo",
                            MarketValue = 0m,
                            Nationality = "Portugal",
                            Position = 7
                        },
                        new
                        {
                            Id = -2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Erling",
                            IsActive = true,
                            LastName = "Haaland",
                            MarketValue = 0m,
                            Nationality = "Norway",
                            Position = 7
                        },
                        new
                        {
                            Id = -3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kylian",
                            IsActive = true,
                            LastName = "Mbappe",
                            MarketValue = 0m,
                            Nationality = "France",
                            Position = 7
                        },
                        new
                        {
                            Id = -4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Vinicius",
                            IsActive = true,
                            LastName = "Junior",
                            MarketValue = 0m,
                            Nationality = "Brazil",
                            Position = 8
                        },
                        new
                        {
                            Id = -5,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Luis",
                            IsActive = true,
                            LastName = "Diaz",
                            MarketValue = 0m,
                            Nationality = "Columbia",
                            Position = 8
                        },
                        new
                        {
                            Id = -6,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Khvicha",
                            IsActive = true,
                            LastName = "Kvaratskhelia",
                            MarketValue = 0m,
                            Nationality = "Brazil",
                            Position = 8
                        },
                        new
                        {
                            Id = -7,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lamine",
                            IsActive = true,
                            LastName = "Yamal",
                            MarketValue = 0m,
                            Nationality = "Spain",
                            Position = 9
                        },
                        new
                        {
                            Id = -8,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bukayo",
                            IsActive = true,
                            LastName = "Saka",
                            MarketValue = 0m,
                            Nationality = "England",
                            Position = 9
                        },
                        new
                        {
                            Id = -9,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Phil",
                            IsActive = true,
                            LastName = "Foden",
                            MarketValue = 0m,
                            Nationality = "England",
                            Position = 9
                        },
                        new
                        {
                            Id = -10,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jude",
                            IsActive = true,
                            LastName = "Bellingham",
                            MarketValue = 0m,
                            Nationality = "England",
                            Position = 5
                        },
                        new
                        {
                            Id = -11,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Florian",
                            IsActive = true,
                            LastName = "Wirtz",
                            MarketValue = 0m,
                            Nationality = "Germany",
                            Position = 5
                        },
                        new
                        {
                            Id = -12,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jamal",
                            IsActive = true,
                            LastName = "Musiala",
                            MarketValue = 0m,
                            Nationality = "Germany",
                            Position = 5
                        },
                        new
                        {
                            Id = -13,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Cole",
                            IsActive = true,
                            LastName = "Palmer",
                            MarketValue = 0m,
                            Nationality = "England",
                            Position = 5
                        },
                        new
                        {
                            Id = -14,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Federico",
                            IsActive = true,
                            LastName = "Valverde",
                            MarketValue = 0m,
                            Nationality = "Uruguay",
                            Position = 4
                        },
                        new
                        {
                            Id = -15,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Declan",
                            IsActive = true,
                            LastName = "Rice",
                            MarketValue = 0m,
                            Nationality = "England",
                            Position = 4
                        },
                        new
                        {
                            Id = -16,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Eduardo",
                            IsActive = true,
                            LastName = "Camavinga",
                            MarketValue = 0m,
                            Nationality = "France",
                            Position = 4
                        },
                        new
                        {
                            Id = -17,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Alexis",
                            IsActive = true,
                            LastName = "Mac Allister",
                            MarketValue = 0m,
                            Nationality = "Argentina",
                            Position = 4
                        },
                        new
                        {
                            Id = -18,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Nicolo",
                            IsActive = true,
                            LastName = "Barella",
                            MarketValue = 0m,
                            Nationality = "Italy",
                            Position = 4
                        },
                        new
                        {
                            Id = -19,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Enzo",
                            IsActive = true,
                            LastName = "Fernandez",
                            MarketValue = 0m,
                            Nationality = "Argentina",
                            Position = 4
                        },
                        new
                        {
                            Id = -20,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Dominik",
                            IsActive = true,
                            LastName = "Szoboszlai",
                            MarketValue = 0m,
                            Nationality = "Hungary",
                            Position = 4
                        },
                        new
                        {
                            Id = -21,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Moises",
                            IsActive = true,
                            LastName = "Caicedo",
                            MarketValue = 0m,
                            Nationality = "Ecuador",
                            Position = 6
                        },
                        new
                        {
                            Id = -22,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bruno",
                            IsActive = true,
                            LastName = "Guimaraes",
                            MarketValue = 0m,
                            Nationality = "Brazil",
                            Position = 6
                        },
                        new
                        {
                            Id = -23,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Aurélien",
                            IsActive = true,
                            LastName = "Tchouaméni",
                            MarketValue = 0m,
                            Nationality = "France",
                            Position = 6
                        },
                        new
                        {
                            Id = -24,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Joao",
                            IsActive = true,
                            LastName = "Neves",
                            MarketValue = 0m,
                            Nationality = "Portugal",
                            Position = 6
                        },
                        new
                        {
                            Id = -25,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Martin",
                            IsActive = true,
                            LastName = "Zubimendi",
                            MarketValue = 0m,
                            Nationality = "Spain",
                            Position = 6
                        },
                        new
                        {
                            Id = -26,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "William",
                            IsActive = true,
                            LastName = "Saliba",
                            MarketValue = 0m,
                            Nationality = "France",
                            Position = 3
                        },
                        new
                        {
                            Id = -27,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Josko",
                            IsActive = true,
                            LastName = "Gvardiol",
                            MarketValue = 0m,
                            Nationality = "Croatia",
                            Position = 2
                        },
                        new
                        {
                            Id = -28,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Gabriel",
                            IsActive = true,
                            LastName = "Magalhaes",
                            MarketValue = 0m,
                            Nationality = "Brazil",
                            Position = 3
                        },
                        new
                        {
                            Id = -29,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Alessandro",
                            IsActive = true,
                            LastName = "Bastoni",
                            MarketValue = 0m,
                            Nationality = "Italy",
                            Position = 3
                        },
                        new
                        {
                            Id = -30,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Trent",
                            IsActive = true,
                            LastName = "Alexander-Arnold",
                            MarketValue = 0m,
                            Nationality = "England",
                            Position = 1
                        },
                        new
                        {
                            Id = -31,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ruben",
                            IsActive = true,
                            LastName = "Dias",
                            MarketValue = 0m,
                            Nationality = "Portugal",
                            Position = 3
                        },
                        new
                        {
                            Id = -32,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Pau",
                            IsActive = true,
                            LastName = "Cubarsi",
                            MarketValue = 0m,
                            Nationality = "Spain",
                            Position = 3
                        },
                        new
                        {
                            Id = -33,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Cristian",
                            IsActive = true,
                            LastName = "Romero",
                            MarketValue = 0m,
                            Nationality = "Argentina",
                            Position = 3
                        },
                        new
                        {
                            Id = -34,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jules",
                            IsActive = true,
                            LastName = "Kounde",
                            MarketValue = 0m,
                            Nationality = "France",
                            Position = 1
                        },
                        new
                        {
                            Id = -35,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Achraf",
                            IsActive = true,
                            LastName = "Hakimi",
                            MarketValue = 0m,
                            Nationality = "Morroco",
                            Position = 1
                        },
                        new
                        {
                            Id = -36,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Federico",
                            IsActive = true,
                            LastName = "Dimarco",
                            MarketValue = 0m,
                            Nationality = "Italy",
                            Position = 2
                        },
                        new
                        {
                            Id = -37,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Nunu",
                            IsActive = true,
                            LastName = "Mendes",
                            MarketValue = 0m,
                            Nationality = "Portugal",
                            Position = 2
                        },
                        new
                        {
                            Id = -38,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Alejandro",
                            IsActive = true,
                            LastName = "Balde",
                            MarketValue = 0m,
                            Nationality = "Spain",
                            Position = 2
                        },
                        new
                        {
                            Id = -39,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Giorgi",
                            IsActive = true,
                            LastName = "Mamardashvilli",
                            MarketValue = 0m,
                            Nationality = "Georgia",
                            Position = 0
                        },
                        new
                        {
                            Id = -40,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Diogo",
                            IsActive = true,
                            LastName = "Costa",
                            MarketValue = 0m,
                            Nationality = "Portugal",
                            Position = 0
                        },
                        new
                        {
                            Id = -41,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "David",
                            IsActive = true,
                            LastName = "Raya",
                            MarketValue = 0m,
                            Nationality = "Spain",
                            Position = 0
                        },
                        new
                        {
                            Id = -42,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Gregor",
                            IsActive = true,
                            LastName = "Kobel",
                            MarketValue = 0m,
                            Nationality = "Switzerland",
                            Position = 0
                        },
                        new
                        {
                            Id = -43,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Gianluigi",
                            IsActive = true,
                            LastName = "Donnarumma",
                            MarketValue = 0m,
                            Nationality = "Italy",
                            Position = 0
                        },
                        new
                        {
                            Id = -44,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Guglielmo",
                            IsActive = true,
                            LastName = "Vicario",
                            MarketValue = 0m,
                            Nationality = "Italy",
                            Position = 0
                        },
                        new
                        {
                            Id = -45,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Andre",
                            IsActive = true,
                            LastName = "Onana",
                            MarketValue = 0m,
                            Nationality = "Cameroon",
                            Position = 0
                        },
                        new
                        {
                            Id = -46,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mike",
                            IsActive = true,
                            LastName = "Maignan",
                            MarketValue = 0m,
                            Nationality = "France",
                            Position = 0
                        },
                        new
                        {
                            Id = -47,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lucas",
                            IsActive = true,
                            LastName = "Chevalier",
                            MarketValue = 0m,
                            Nationality = "France",
                            Position = 0
                        },
                        new
                        {
                            Id = -48,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Unai",
                            IsActive = true,
                            LastName = "Simon",
                            MarketValue = 0m,
                            Nationality = "Spain",
                            Position = 0
                        },
                        new
                        {
                            Id = -49,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Anatoliy",
                            IsActive = true,
                            LastName = "Trubin",
                            MarketValue = 0m,
                            Nationality = "Ukraine",
                            Position = 0
                        });
                });

            modelBuilder.Entity("FM.Data.Entities.AthleteTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AthleteId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AthleteId");

                    b.HasIndex("TeamId");

                    b.ToTable("AthleteTeam");
                });

            modelBuilder.Entity("FM.Data.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<decimal>("Earnings")
                        .HasColumnType("decimal(19, 2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FM.Data.Entities.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AthleteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<decimal>("TransferValue")
                        .HasColumnType("decimal(19, 2)");

                    b.HasKey("Id");

                    b.HasIndex("AthleteId");

                    b.HasIndex("TeamId");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("FM.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FM.Data.Entities.AthleteTeam", b =>
                {
                    b.HasOne("FM.Data.Entities.Athlete", "Athlete")
                        .WithMany()
                        .HasForeignKey("AthleteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FM.Data.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Athlete");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FM.Data.Entities.Transfer", b =>
                {
                    b.HasOne("FM.Data.Entities.Athlete", "Athlete")
                        .WithMany()
                        .HasForeignKey("AthleteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FM.Data.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Athlete");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
