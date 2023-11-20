using System.ComponentModel.DataAnnotations;

namespace WinFormsAppWithApi;
public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
}
