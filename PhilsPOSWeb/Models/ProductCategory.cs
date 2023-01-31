using System.ComponentModel.DataAnnotations;

namespace PhilsPOSWeb.Models
{
    public class ProductCategory
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
