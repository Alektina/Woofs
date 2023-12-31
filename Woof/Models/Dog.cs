﻿namespace Woof.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Dog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DogID { get; set; } // Automatically generated by the database

        public string? RegNr { get; set; }
        [Required]
        public string Name { get; set; }

        public string? Nickname { get; set; }

        public string? Sex { get; set; } // Can be either "Male" or "Female" somehow

        public int? CountryID { get; set; } // Foreign key to the Countries table

        public DateTime? BirthDate { get; set; }

        public DateTime? DeathDate { get; set; } // Can be null

        public string? Color { get; set; }

        public string? Hairlayers { get; set; }

        public string? Size { get; set; }

        public int? OriginalBreederID { get; set; } // Picked from a UserID, can be null

        public int? CurrentOwnerID { get; set; } // Picked from UserID, can be null

        public int? MotherDogID { get; set; } // Linked with another DogID, can be null

        public int? FatherDogID { get; set; } // Linked with another DogID, can be null

        public int? BroodID { get; set; } // Links Broods

        public int? LitterID { get; set; } // Links Litters

        public string? Description { get; set; } // Can be null

        public List<Image>? Images { get; set; }
        public string? Merits { get; set; } // Can be null
        public string? Titles { get; set; } // Can be null

    }

}
