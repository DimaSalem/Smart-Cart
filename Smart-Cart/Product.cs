using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class Product
    {
        public enum enProductCategory { Food, Clothing, Electronics }
        public string Name { get; set; }
        public int Price { get; set; }
        public enProductCategory Category { get; set; }

        public Product(string name, int Price, enProductCategory productCategory)
        {
            this.Name = name;
            this.Price = Price;
            this.Category = productCategory;
        }
    }
}
