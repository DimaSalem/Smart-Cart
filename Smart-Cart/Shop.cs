using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Smart_Cart
{
    public class Shop
    {
        private FoodSection foodSection= new FoodSection();
        private ClothingSection clothingSection= new ClothingSection();
        private ElectronicsSection electronicSection= new ElectronicsSection();

        private ShoppingCart shoppingCart= new ShoppingCart();
        private enum enOptions { FoodSection= 1, ClothingSection=2 , ElectronicSection=3, ShoppingCart=4, Checkout=5 }
        private void PrintMainMenue()
        {
            Console.WriteLine("Welcome to Dima's Store\n");
            Console.WriteLine("1. Food Section");
            Console.WriteLine("2. Clothing Section");
            Console.WriteLine("3. Electronic Section");
            Console.WriteLine("4. Shopping Cart");
            Console.WriteLine("5. Checkout\n");
        }
        private enOptions GetValidOption()
        {
            string input;
            int option;
            do
            {
                Console.WriteLine("Where do you want to go?");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out option) || option < 1 || option > 5);
            return (enOptions)option;
        }
        private void AddProductToCart(List<Product> products)
        {
            string input;
            int productIndex;
            Console.WriteLine("select a product to add to your cart");
            input= Console.ReadLine();
   
            while (!int.TryParse(input, out productIndex) || productIndex < 1 || productIndex > products.Count())
            {
                Console.WriteLine("please select from the available products!");
                input= Console.ReadLine();
            }
            shoppingCart.Add(products[productIndex - 1]);
        }
        private void RemoveProductFromCart()
        {
            string input;
            int productIndex;
            Console.WriteLine("select a product to remove from your cart");
            input = Console.ReadLine();

            while (!int.TryParse(input, out productIndex) || productIndex < 1 || productIndex > shoppingCart.Count())
            {
                Console.WriteLine("please select from the products in the cart!");
                input = Console.ReadLine();
            }
            shoppingCart.RemoveAt(productIndex-1);
        }
        private void DisplaySectionProducts(List<Product> products) 
        {
            for (int i = 0; i < products.Count(); i++)
            {
                Console.WriteLine($"[{i + 1}] {products[i].Name} {products[i].Price}JD");
            }
        }
        private void DisplayShoppingCartProducts(List<Product> products)
        {
            for (int i = 0; i < products.Count(); i++)
            {
                Console.WriteLine($"[{i + 1}] {products[i].Name} {products[i].Price}JD");
            }
        }
        private void DisplaySection(Section section)
        {
            string exit;
            string addToCart;

            Console.Clear();
            Console.WriteLine($"{section.SectionName}\n");
            DisplaySectionProducts(section.Products);
            do
            {
                Console.WriteLine("do you want to add products to your cart? Y/N");
                addToCart = Console.ReadLine();
                if (addToCart.ToUpper() == "Y")
                    AddProductToCart(section.Products);

                Console.WriteLine("Exit? Y/N");
                exit = Console.ReadLine();
            } while (exit.ToUpper() != "Y");
        }
        private void DisplayShoppingCart()
        {
            Console.Clear();
            if(shoppingCart.Count() == 0)
            {
                Console.WriteLine("Your cart is empty!");
                Console.WriteLine("press any key to go back");
                Console.ReadKey();
            }

            else
            {
                string exit;
                string removeFromCart;
                Console.WriteLine($"Shopping Cart\n");
                DisplayShoppingCartProducts(shoppingCart.GetProducts());
                Console.WriteLine($"Total Price= {shoppingCart.TotalPrice}\n");
                do
                {
                    Console.WriteLine("Do you want to remove a product from the cart? Y/N");
                    removeFromCart = Console.ReadLine();
                    if (removeFromCart.ToUpper() == "Y")
                    {
                        RemoveProductFromCart();
                        DisplayShoppingCart();
                        return;
                    }

                    Console.WriteLine("Exit? Y/N");
                    exit = Console.ReadLine();
                } while (exit.ToUpper() != "Y");                
            }            
        }
        private bool PerformOption(enOptions option)
        {
            switch(option)
            {
                case enOptions.FoodSection:
                    DisplaySection(foodSection);
                    break;
                case enOptions.ClothingSection:
                    DisplaySection(clothingSection);
                    break;
                case enOptions.ElectronicSection:
                    DisplaySection(electronicSection);
                    break;
                case enOptions.ShoppingCart:
                    DisplayShoppingCart();
                    break;
                case enOptions.Checkout:
                    return true;

            }
            return false;
        }
        public void StartShopping()
        {
            while(true)
            {
                Console.Clear();
                PrintMainMenue();
                bool finishShopping= PerformOption(GetValidOption());
                if (finishShopping == true) break;
                
            }

        }
    }
}
