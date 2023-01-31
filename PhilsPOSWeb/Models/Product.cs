namespace PhilsPOSWeb.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid ProductCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } = 0.0M;
        public ProductCategory ProductCategory { get; set; }    

    }
}
