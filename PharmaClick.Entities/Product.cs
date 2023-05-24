using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaClick.Entities
{
    public class Product : BaseEntity
    {

        public decimal Price { get; set; }
        public Category Category { get; set; } // This will be used as men or women or baby products
        
    }
}
