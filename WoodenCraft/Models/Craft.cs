using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WoodenCraft;

[Table("Craft")]
public class Craft
{
    [Key] public int Id { get; set; }
    [Required] public string Name { get; set; } = "";
    [Required] public string Description { get; set; } = "";
    [Required] public int Size { get; set; } = 48;
    [Required] public double Price { get; set; } = 99.99;
    
    [Required] public string Url { get; set; } = "";
}