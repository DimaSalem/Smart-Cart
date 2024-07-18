using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ProductGenerator
    {
        public List<Product> FoodSection {  get; set; }
        public List<Product> ClothingSection { get; set; }
        public List<Product> ElectronicsSection { get; set; }

        public ProductGenerator()
        {
            FoodSection = new List<Product>();
            ClothingSection = new List<Product>();
            ElectronicsSection = new List<Product>();

            GenerateProduct();
        }
        public void GenerateProduct()
        {
            FoodSection.Add(new Product("Rice", 3, Product.enProductCategory.Food));
            FoodSection.Add(new Product("Bread", 1, Product.enProductCategory.Food));
            FoodSection.Add(new Product("Chicken", 5, Product.enProductCategory.Food));
            FoodSection.Add(new Product("Yogurt", 1, Product.enProductCategory.Food));
            FoodSection.Add(new Product("Candy", 2, Product.enProductCategory.Food));

            ClothingSection.Add(new Product("Plouse", 7, Product.enProductCategory.Clothing));
            ClothingSection.Add(new Product("Pant", 8, Product.enProductCategory.Clothing));
            ClothingSection.Add(new Product("Jaket", 15, Product.enProductCategory.Clothing));
            ClothingSection.Add(new Product("Shoes", 10, Product.enProductCategory.Clothing));

            ElectronicsSection.Add(new Product("Water Heater 2L", 20, Product.enProductCategory.Electronics));
            ElectronicsSection.Add(new Product("Fan", 40, Product.enProductCategory.Electronics));
            ElectronicsSection.Add(new Product("Stand Mixer", 30, Product.enProductCategory.Electronics));
            ElectronicsSection.Add(new Product("Clothing Iron", 50, Product.enProductCategory.Electronics));

        }

    }
}
