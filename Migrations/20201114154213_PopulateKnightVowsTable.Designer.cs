﻿// <auto-generated />
using System;
using Knights.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Knights.Migrations
{
    [DbContext(typeof(KnightsContext))]
    [Migration("20201114154213_PopulateKnightVowsTable")]
    partial class PopulateKnightVowsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Knights.Models.Horse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KnightId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KnightId")
                        .IsUnique();

                    b.ToTable("Horses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Brown",
                            KnightId = 1,
                            Name = "Rex"
                        },
                        new
                        {
                            Id = 2,
                            Color = "White",
                            KnightId = 2,
                            Name = "Moondancer"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Grey",
                            KnightId = 6,
                            Name = "Trout"
                        },
                        new
                        {
                            Id = 4,
                            Color = "Black",
                            KnightId = 5,
                            Name = "Ash"
                        },
                        new
                        {
                            Id = 5,
                            Color = "Dark brown",
                            KnightId = 4,
                            Name = "Mel"
                        },
                        new
                        {
                            Id = 6,
                            Color = "Chesnut",
                            KnightId = 3,
                            Name = "Honour"
                        },
                        new
                        {
                            Id = 7,
                            Color = "Dun",
                            KnightId = 7,
                            Name = "Justice"
                        });
                });

            modelBuilder.Entity("Knights.Models.Knight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Castle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Land")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Knights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Castle = "Rainhaven",
                            Land = "Reach",
                            Name = "Ser Hugar Roxton"
                        },
                        new
                        {
                            Id = 2,
                            Castle = "Rainhaven",
                            Land = "Reach",
                            Name = "Ser Dareon Flowers"
                        },
                        new
                        {
                            Id = 3,
                            Castle = "Casterly Rock",
                            Land = "Westerlands",
                            Name = "Ser Jaime Lannister"
                        },
                        new
                        {
                            Id = 4,
                            Castle = "Rainwood",
                            Land = "Stormlands",
                            Name = "Ser Davos Seaworth"
                        },
                        new
                        {
                            Id = 5,
                            Castle = "Red Keep",
                            Land = "Crownlands",
                            Name = "Ser Barristan Selmy"
                        },
                        new
                        {
                            Id = 6,
                            Castle = "Riverrun",
                            Land = "Riverlands",
                            Name = "Ser Brynden Tully"
                        },
                        new
                        {
                            Id = 7,
                            Castle = "Evenfall Hall",
                            Land = "Stormlands",
                            Name = "Lady Brienne of Tarth"
                        });
                });

            modelBuilder.Entity("Knights.Models.KnightsVows", b =>
                {
                    b.Property<int>("KnightId")
                        .HasColumnType("int");

                    b.Property<int>("VowId")
                        .HasColumnType("int");

                    b.HasKey("KnightId", "VowId");

                    b.HasIndex("VowId");

                    b.ToTable("KnightsVows");

                    b.HasData(
                        new
                        {
                            KnightId = 1,
                            VowId = 2
                        },
                        new
                        {
                            KnightId = 1,
                            VowId = 4
                        },
                        new
                        {
                            KnightId = 1,
                            VowId = 5
                        },
                        new
                        {
                            KnightId = 2,
                            VowId = 1
                        },
                        new
                        {
                            KnightId = 2,
                            VowId = 7
                        },
                        new
                        {
                            KnightId = 3,
                            VowId = 6
                        },
                        new
                        {
                            KnightId = 3,
                            VowId = 5
                        },
                        new
                        {
                            KnightId = 3,
                            VowId = 7
                        },
                        new
                        {
                            KnightId = 3,
                            VowId = 1
                        },
                        new
                        {
                            KnightId = 3,
                            VowId = 3
                        },
                        new
                        {
                            KnightId = 4,
                            VowId = 6
                        },
                        new
                        {
                            KnightId = 4,
                            VowId = 3
                        },
                        new
                        {
                            KnightId = 4,
                            VowId = 2
                        },
                        new
                        {
                            KnightId = 5,
                            VowId = 1
                        },
                        new
                        {
                            KnightId = 5,
                            VowId = 2
                        },
                        new
                        {
                            KnightId = 5,
                            VowId = 3
                        },
                        new
                        {
                            KnightId = 5,
                            VowId = 4
                        },
                        new
                        {
                            KnightId = 5,
                            VowId = 5
                        },
                        new
                        {
                            KnightId = 5,
                            VowId = 6
                        },
                        new
                        {
                            KnightId = 5,
                            VowId = 7
                        },
                        new
                        {
                            KnightId = 6,
                            VowId = 1
                        },
                        new
                        {
                            KnightId = 6,
                            VowId = 2
                        },
                        new
                        {
                            KnightId = 7,
                            VowId = 3
                        },
                        new
                        {
                            KnightId = 7,
                            VowId = 4
                        },
                        new
                        {
                            KnightId = 7,
                            VowId = 7
                        });
                });

            modelBuilder.Entity("Knights.Models.Vow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Be brave",
                            Name = "Warrior"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Be just",
                            Name = "Father"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Protect the innocent",
                            Name = "Mother"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Protect all women",
                            Name = "Maiden"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Obey your liege lord",
                            Name = "Smith"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Obey your king",
                            Name = "Crone"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Fight bravely when needed and do such other tasks as are laid upon you, however hard or humble or dangerous they may be",
                            Name = "Stranger"
                        });
                });

            modelBuilder.Entity("Knights.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KnightId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KnightId");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("Knights.Models.Horse", b =>
                {
                    b.HasOne("Knights.Models.Knight", "Owner")
                        .WithOne("Steed")
                        .HasForeignKey("Knights.Models.Horse", "KnightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Knights.Models.KnightsVows", b =>
                {
                    b.HasOne("Knights.Models.Knight", "Knight")
                        .WithMany("KnightsVows")
                        .HasForeignKey("KnightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Knights.Models.Vow", "Vow")
                        .WithMany("KnightsVows")
                        .HasForeignKey("VowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Knights.Models.Weapon", b =>
                {
                    b.HasOne("Knights.Models.Knight", "Knight")
                        .WithMany("Weapons")
                        .HasForeignKey("KnightId");
                });
#pragma warning restore 612, 618
        }
    }
}
