using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakaryshop.Model
{
    public class Product
    {
        public int id { get; set; }
        public string product_name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string imagename { get; set; }
    }
}
