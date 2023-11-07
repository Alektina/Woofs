using System.ComponentModel.DataAnnotations;

public class Image
{
    public int ImageID { get; set; } // Primary key

    [Required]
    public string ImageName { get; set; }

    [Required]
    public string ImagePath { get; set; }

}