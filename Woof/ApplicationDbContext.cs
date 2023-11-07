namespace Woof
   
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Woof.Models;
    using System;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Kennel> Kennels { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Table Dogs
            modelBuilder.Entity<Dog>().HasData(
                new Dog
                {
                    DogID = 1,
                    RegNr = "TS33817204",
                    Name = "Hi-Life's Grand Finale",
                    Nickname = "Prince",
                    Sex = "Male",
                    CountryID = 1,
                    BirthDate = new DateTime(2017, 4, 2),
                    DeathDate = null,
                    Color = "Brown",
                    Size = "Medium",
                    Hairlayers = "Hairless",
                    OriginalBreederID = null,
                    CurrentOwnerID = null,
                    FatherDogID = 2,
                    MotherDogID = 3,
                    Description = "This is a sample dog description.",
                    Images = null,
                    Merits = "Best in Show",
                    Titles = "ACCCCH"
                });

            modelBuilder.Entity<Dog>().HasData(
               new Dog
               {
                   DogID = 2,
                   RegNr = null,
                   Name = "Edelweiss Too Sexy for my Shirt",
                   Nickname = null,
                   Sex = "Male",
                   CountryID = 1,
                   BirthDate = new DateTime(2015, 8, 2),
                   DeathDate = null,
                   Color = "White",
                   Size = "Small",
                   Hairlayers = "Hairless",
                   OriginalBreederID = null,
                   CurrentOwnerID = null,
                   FatherDogID = 4,
                   MotherDogID = 5,
                   Description = "This is a sample dog description.",
                   Images = null,
                   Merits = "Best in Show",
                   Titles = "ACCCCH"
               });

            modelBuilder.Entity<Dog>().HasData(
               new Dog
               {
                   DogID = 3,
                   RegNr = null,
                   Name = "Hi-Life's Sirius Image of the Sun at Zen",
                   Nickname = null,
                   Sex = "Female",
                   CountryID = 1,
                   BirthDate = null,
                   DeathDate = null,
                   Color = "Dotted",
                   Size = "Medium",
                   Hairlayers = "Testing",
                   OriginalBreederID = null,
                   CurrentOwnerID = null,
                   FatherDogID = 6,
                   MotherDogID = 7,
                   Description = "This is a sample dog description.",
                   Images = null,
                   Merits = null,
                   Titles = null
               });

            modelBuilder.Entity<Dog>().HasData(
               new Dog
               {
                   DogID = 4,
                   RegNr = "TS06970704",
                   Name = "Edelweiss Natalie's Mountain Man SOM",
                   Nickname = "Jake",
                   Sex = "Male",
                   CountryID = 1,
                   BirthDate = new DateTime(2011, 10, 28),
                   DeathDate = null,
                   Color = "Cream",
                   Size = "Medium",
                   Hairlayers = "Powderpuff",
                   OriginalBreederID = null,
                   CurrentOwnerID = null,
                   FatherDogID = null,
                   MotherDogID = null,
                   Description = "This is a sample dog description.",
                   Images = null,
                   Merits = "Ok in Show",
                   Titles = "AMCH"
               });

            modelBuilder.Entity<Dog>().HasData(
               new Dog
               {
                   DogID = 5,
                   RegNr = "TS07482701",
                   Name = "Edelweiss Dirty Sexy Money",
                   Nickname = "Lexee",
                   Sex = "Female",
                   CountryID = 3,
                   BirthDate = new DateTime(2011, 7, 14),
                   DeathDate = null,
                   Color = "Black & White",
                   Size = "Tiny",
                   Hairlayers = "Hairless",
                   OriginalBreederID = null,
                   CurrentOwnerID = null,
                   FatherDogID = null,
                   MotherDogID = null,
                   Description = "This is a sample dog description.",
                   Images = null,
                   Merits = null,
                   Titles = "AMCH - Gold Grand Champion"
               });

            modelBuilder.Entity<Dog>().HasData(
               new Dog
               {
                   DogID = 6,
                   RegNr = " TR43989201",
                   Name = "Expression-All Fired Up",
                   Nickname = "Fire",
                   Sex = "Male",
                   CountryID = 2,
                   BirthDate = new DateTime(2005, 5, 21),
                   DeathDate = null,
                   Color = null,
                   Size = null,
                   Hairlayers = "Hairless",
                   OriginalBreederID = null,
                   CurrentOwnerID = null,
                   FatherDogID = null,
                   MotherDogID = null,
                   Description = null,
                   Images = null,
                   Merits = null,
                   Titles = "AMCH"
               });

            modelBuilder.Entity<Dog>().HasData(
               new Dog
               {
                   DogID = 7,
                   RegNr = "TR45790401",
                   Name = "Hi-Life's Tang Gao Of The Sun",
                   Nickname = null,
                   Sex = "Female",
                   CountryID = 1,
                   BirthDate = new DateTime(2005, 9, 1),
                   DeathDate = null,
                   Color = "Black and white",
                   Size = "31,75cm (12.5inches)",
                   Hairlayers = "Powderpuff",
                   OriginalBreederID = null,
                   CurrentOwnerID = null,
                   FatherDogID = null,
                   MotherDogID = null,
                   Description = "This is a sample dog description.",
                   Images = null,
                   Merits = null,
                   Titles = null
               });

            modelBuilder.Entity<Dog>().HasData(
               new Dog
               {
                   DogID = 8,
                   RegNr = null,
                   Name = "Edelweiss Too Sexy For Your Party At Blacks",
                   Nickname = "Venus",
                   Sex = "Female",
                   CountryID = 2,
                   BirthDate = new DateTime(2015, 8, 2),
                   DeathDate = null,
                   Color = "Black & White",
                   Size = "31.75cm (12.5inches) / 5kg",
                   Hairlayers = "Hairless",
                   OriginalBreederID = null,
                   CurrentOwnerID = null,
                   FatherDogID = 4,
                   MotherDogID = 5,
                   Description = "This is a sample dog description.",
                   Images = null,
                   Merits = null,
                   Titles = "AMCH - BronzeGCH"
               });



            //Table Country
            modelBuilder.Entity<Country>().HasData(
               new Country
               {
                   CountryID = 1,
                   CountryName = "England"
               });

            modelBuilder.Entity<Country>().HasData(
               new Country
               {
                   CountryID = 2,
                   CountryName = "Sweden"
               });
            modelBuilder.Entity<Country>().HasData(
               new Country
               {
                   CountryID = 3,
                   CountryName = "Denmark"
               });



            //Table Roles
            modelBuilder.Entity<Role>().HasData(
               new Role
               {
                   RoleID = 1,
                   RoleName = "Bronze"
               });
            modelBuilder.Entity<Role>().HasData(
               new Role
               {
                   RoleID = 2,
                   RoleName = "Silver"
               });
            modelBuilder.Entity<Role>().HasData(
               new Role
               {
                   RoleID = 3,
                   RoleName = "Gold"
               });
            modelBuilder.Entity<Role>().HasData(
               new Role
               {
                   RoleID = 4,
                   RoleName = "Admin"
               });

            //Table Users
            modelBuilder.Entity<User>().HasData(
               new User
               {
                   UserID = 1,
                   Username = "Admin",
                   Email = "admin@admin",
                   Password = "admin",
                   KennelID = null,
                   RoleID = 4,
               });

            modelBuilder.Entity<User>().HasData(
               new User
               {
                   UserID = 2,
                   Username = "Bronze",
                   Email = "bronze@bronze",
                   Password = "bronze",
                   KennelID = null,
                   RoleID = 1,
               });

            modelBuilder.Entity<User>().HasData(
               new User
               {
                   UserID = 3,
                   Username = "Silver",
                   Email = "silver@silver",
                   Password = "silver",
                   KennelID = null,
                   RoleID = 2,
               });

            modelBuilder.Entity<User>().HasData(
               new User
               {
                   UserID = 4,
                   Username = "Gold",
                   Email = "gold@gold",
                   Password = "gold",
                   KennelID = null,
                   RoleID = 3,
               });
        }
    }
}

