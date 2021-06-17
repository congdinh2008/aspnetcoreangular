using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Product: Entity
    {
        public string Name { get; set; }

        public string Summary { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
