namespace ProductsAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public ProductCategory Category { get; set; }
    }

    public enum ProductCategory
    {
        Food = 0,
        Drink = 1,
        Electronics = 3,
        Other = 4
    }
}
