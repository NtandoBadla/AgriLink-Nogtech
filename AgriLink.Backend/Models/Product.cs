namespace AgriLink.Backend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public int FarmerId { get; set; }
        public int Stock { get; set; }
        public User? Farmer { get; set; }
    }
}
