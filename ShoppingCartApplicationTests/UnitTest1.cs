using Smart_Cart;

namespace ShoppingCartApplicationTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddItemToCartTest()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Add(new Product("Bag", 10, Product.enProductCategory.Clothing));

            List <Product> expectedOutput= new List<Product>();
            expectedOutput.Add(new Product("Bag", 10, Product.enProductCategory.Clothing));

            List <Product> actualOutput= cart.GetProducts();
            Assert.Equal(expectedOutput[0].Name, actualOutput[0].Name);
        }

        [Fact]
        public void RemoveItemFromCartTest()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Add(new Product("Bag", 10, Product.enProductCategory.Clothing));
            cart.RemoveAt(0);            

            Assert.True(cart.Count()==0);
        }

        [Fact]
        public void TotalCostCalculationTest()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Add(new Product("Bag", 10, Product.enProductCategory.Clothing));
            cart.Add(new Product("shoes", 20, Product.enProductCategory.Clothing));

            Assert.True(cart.TotalPrice == 30);
        }
    }
}