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
    [Migration("20231027085208_teststst")]
    partial class teststst
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Woof.Models.Brood", b =>
                {
                    b.Property<int>("BroodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BroodID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FatherDogID")
                        .HasColumnType("int");

                    b.Property<int>("MotherDogID")
                        .HasColumnType("int");

                    b.HasKey("BroodID");

                    b.ToTable("Broods");
                });

            modelBuilder.Entity("Woof.Models.Country", b =>
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

            modelBuilder.Entity("Woof.Models.Dog", b =>
                {
                    b.Property<int>("DogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DogID"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BroodID")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<int?>("CurrentOwnerID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FatherDogID")
                        .HasColumnType("int");

                    b.Property<string>("Hairlayers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MotherDogID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OriginalBreederID")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DogID");

                    b.HasIndex("BroodID");

                    b.HasIndex("CountryID");

                    b.HasIndex("CurrentOwnerID");

                    b.HasIndex("OriginalBreederID");

                    b.ToTable("Dogs");
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

            modelBuilder.Entity("Woof.Models.Merit", b =>
                {
                    b.Property<int>("MeritID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MeritID"));

                    b.Property<string>("MeritName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MeritID");

                    b.ToTable("Merits");
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

            modelBuilder.Entity("Woof.Models.Title", b =>
                {
                    b.Property<int>("TitleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TitleID"));

                    b.Property<string>("TitleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TitleID");

                    b.ToTable("Titles");
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

                    b.HasIndex("KennelID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Woof.Models.Dog", b =>
                {
                    b.HasOne("Woof.Models.Brood", "Brood")
                        .WithMany()
                        .HasForeignKey("BroodID");

                    b.HasOne("Woof.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Woof.Models.User", "CurrentOwner")
                        .WithMany()
                        .HasForeignKey("CurrentOwnerID");

                    b.HasOne("Woof.Models.User", "OriginalBreeder")
                        .WithMany()
                        .HasForeignKey("OriginalBreederID");

                    b.Navigation("Brood");

                    b.Navigation("Country");

                    b.Navigation("CurrentOwner");

                    b.Navigation("OriginalBreeder");
                });

            modelBuilder.Entity("Woof.Models.User", b =>
                {
                    b.HasOne("Woof.Models.Kennel", "Kennel")
                        .WithMany()
                        .HasForeignKey("KennelID");

                    b.HasOne("Woof.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kennel");

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
