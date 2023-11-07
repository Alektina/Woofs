﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Woof;

#nullable disable

namespace Woof.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231106150641_ploise")]
    partial class ploise
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryID"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Image", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<int?>("DogID")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageID");

                    b.HasIndex("DogID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Woof.Models.Dog", b =>
                {
                    b.Property<int>("DogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DogID"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BroodID")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryID")
                        .HasColumnType("int");

                    b.Property<int?>("CurrentOwnerID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FatherDogID")
                        .HasColumnType("int");

                    b.Property<string>("Hairlayers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LitterID")
                        .HasColumnType("int");

                    b.Property<string>("Merits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MotherDogID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OriginalBreederID")
                        .HasColumnType("int");

                    b.Property<string>("RegNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titles")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DogID");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogID = -1,
                            BirthDate = new DateTime(2017, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Color = "Brown",
                            CountryID = 1,
                            Description = "This is a sample dog description.",
                            FatherDogID = -2,
                            Hairlayers = "Hairless",
                            Merits = "Best in Show",
                            MotherDogID = -3,
                            Name = "Hi-Life's Grand Finale",
                            Nickname = "Prince",
                            RegNr = "TS33817204",
                            Sex = "Male",
                            Size = "Medium",
                            Titles = "ACCCCH"
                        },
                        new
                        {
                            DogID = -2,
                            BirthDate = new DateTime(2015, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Color = "White",
                            CountryID = 1,
                            Description = "This is a sample dog description.",
                            FatherDogID = -4,
                            Hairlayers = "Hairless",
                            Merits = "Best in Show",
                            MotherDogID = -5,
                            Name = "Edelweiss Too Sexy for my Shirt",
                            Sex = "Male",
                            Size = "Small",
                            Titles = "ACCCCH"
                        },
                        new
                        {
                            DogID = -3,
                            Color = "Dotted",
                            CountryID = 1,
                            Description = "This is a sample dog description.",
                            FatherDogID = -6,
                            Hairlayers = "Testing",
                            MotherDogID = -7,
                            Name = "Hi-Life's Sirius Image of the Sun at Zen",
                            Sex = "Female",
                            Size = "Medium"
                        },
                        new
                        {
                            DogID = -4,
                            BirthDate = new DateTime(2011, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Color = "Cream",
                            CountryID = 1,
                            Description = "This is a sample dog description.",
                            Hairlayers = "Powderpuff",
                            Merits = "Ok in Show",
                            Name = "Edelweiss Natalie's Mountain Man SOM",
                            Nickname = "Jake",
                            RegNr = "TS06970704",
                            Sex = "Male",
                            Size = "Medium",
                            Titles = "AMCH"
                        },
                        new
                        {
                            DogID = -5,
                            BirthDate = new DateTime(2011, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Color = "Black & White",
                            CountryID = 1,
                            Description = "This is a sample dog description.",
                            Hairlayers = "Hairless",
                            Name = "Edelweiss Dirty Sexy Money",
                            Nickname = "Lexee",
                            RegNr = "TS07482701",
                            Sex = "Female",
                            Size = "Tiny",
                            Titles = "AMCH - Gold Grand Champion"
                        },
                        new
                        {
                            DogID = -6,
                            BirthDate = new DateTime(2005, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryID = 1,
                            Hairlayers = "Hairless",
                            Name = "Expression-All Fired Up",
                            Nickname = "Fire",
                            RegNr = " TR43989201",
                            Sex = "Male",
                            Titles = "AMCH"
                        },
                        new
                        {
                            DogID = -7,
                            BirthDate = new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Color = "Black and white",
                            CountryID = 1,
                            Description = "This is a sample dog description.",
                            Hairlayers = "Powderpuff",
                            Name = "Hi-Life's Tang Gao Of The Sun",
                            RegNr = "TR45790401",
                            Sex = "Female",
                            Size = "31,75cm (12.5inches)"
                        },
                        new
                        {
                            DogID = -8,
                            BirthDate = new DateTime(2015, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Color = "Black & White",
                            CountryID = 1,
                            Description = "This is a sample dog description.",
                            FatherDogID = -4,
                            Hairlayers = "Hairless",
                            MotherDogID = -5,
                            Name = "Edelweiss Too Sexy For Your Party At Blacks",
                            Nickname = "Venus",
                            Sex = "Female",
                            Size = "31.75cm (12.5inches) / 5kg",
                            Titles = "AMCH - BronzeGCH"
                        });
                });

            modelBuilder.Entity("Woof.Models.Kennel", b =>
                {
                    b.Property<int>("KennelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KennelID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KennelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KennelID");

                    b.ToTable("Kennels");
                });

            modelBuilder.Entity("Woof.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Woof.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("KennelID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Image", b =>
                {
                    b.HasOne("Woof.Models.Dog", null)
                        .WithMany("Images")
                        .HasForeignKey("DogID");
                });

            modelBuilder.Entity("Woof.Models.Dog", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
