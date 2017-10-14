using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }

    }
}
