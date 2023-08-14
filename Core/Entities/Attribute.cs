using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        [NotMapped]
        public Category Category { get; set; }
        [NotMapped]
        public virtual IEnumerable<JTProductAttribute> JTProductVariations { get; set; }
    }
}
