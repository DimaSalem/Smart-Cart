using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class Section
    {
        public List<Product>? Products;
        public ProductGenerator productGenerator;
        public string SectionName {  get; set; }
        public Section()
        {
             productGenerator = new ProductGenerator();
        }
    }
    public class FoodSection: Section
    {
        public FoodSection()
        {
            SectionName = "Food Section";
            Products = productGenerator.FoodSection;
        }
    }
    public class ClothingSection : Section
    {
        public ClothingSection()
        {
            SectionName = "Clothing Section";
            Products = productGenerator.ClothingSection;
        }
    }
    public class ElectronicsSection : Section
    {
        public ElectronicsSection()
        {
            SectionName = "Electronics Section";
            Products = productGenerator.ElectronicsSection;
        }
    }
}
