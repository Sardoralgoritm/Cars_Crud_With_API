namespace ApiFirst.Models;

public class CarDto
{
    public string Brand { get; set; } = string.Empty;
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
}
