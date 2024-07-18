using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ShoppingCart
    {
        //should add the declaration with new here
        private List<Product> Items;
        public int TotalPrice { get; set; }

        public ShoppingCart()
        {
            Items = new List<Product>();
            TotalPrice = 0;
        }
        public void Add(Product product)
        {
            Items.Add(product);
            TotalPrice += product.Price;
        }
        public void RemoveAt(int index)
        {
            TotalPrice-= Items[index].Price;
            Items.RemoveAt(index);
        }
        public List<Product> GetProducts()
        {
          return Items;
        }
        public int Count()
        { 
            return Items.Count();
        }
    }
}
