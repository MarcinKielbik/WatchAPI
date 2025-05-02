using System.ComponentModel.DataAnnotations;

namespace WatchAPI.Models;

public class Watch
{
    [Key]
    public int Id {get; set;}
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Type { get; set; } = string.Empty; // Luxury, Budget, etc.
    public string Img {get; set; }
}