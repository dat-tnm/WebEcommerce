using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class JTProductAttribute
    {
        public int ProductVariationId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }

        [NotMapped]
        public ProductVariation ProductVariation { get; set; }
        [NotMapped]
        public Attribute Attribute { get; set; }
    }
}
