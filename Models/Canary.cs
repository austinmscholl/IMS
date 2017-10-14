using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Canary
    {
        public int CanaryId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breeder { get; set; }
        public decimal Cost { get; set; }
        public string Gender { get; set; }
        public bool Sold { get; set; }
        public bool Deceased { get; set; }
    }
}
