using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ProductVariation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? SKU { get; set; }
        public decimal QtyInStock { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public int ProductId { get; set; }

        [NotMapped]
        public Product Product { get; set; }
        [NotMapped]
        public virtual IEnumerable<JTProductAttribute> JTProductVariations { get; set; }
    }
}
