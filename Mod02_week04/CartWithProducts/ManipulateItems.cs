using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CartWithProducts
{
    public class ManipulateItems
    {
        public static Cart Populate()
        {
            Cart cart1 = new Cart { ProductType = ProductType.Book, Name = "Angular Basics" };
            Product product1 = new Product { ProductType = ProductType.Book, Name = "React Basics", Price = 105.25 };

            IReadOnlyCollection<Product> products = new List<Product>()
            {
                product1,
                new Product { ProductType = ProductType.Clothes, Name="AT-Shirt", Price= 345.3},
                new Product { ProductType = ProductType.Clothes, Name="BJacket", Price= 365.3},
                new Product { ProductType = ProductType.Food, Name="Banana", Price= 34.2},
                new Product { ProductType = ProductType.Food, Name="Milk", Price= 118.2},
                new Product { ProductType = ProductType.Food, Name="Apple", Price= 206.2},
                new Product { ProductType = ProductType.Book, Name="Asp NET", Price= 16.4},
                new Product { ProductType = ProductType.Book, Name="Dot NET", Price= 427.4},
            };

            Cart cartWithProducts = new Cart();
            cartWithProducts.Products = new List<Product>();

            List<Product> graterThan200List = products.Where(p => p.Price > 200).ToList();
            cartWithProducts.Products.AddRange(graterThan200List);

            List<Product> clothesStartingWithB = products.Where(p => p.Name.StartsWith("B")
            && p.ProductType == ProductType.Clothes).ToList();
            cartWithProducts.Products.AddRange(clothesStartingWithB);

            IEnumerable<Product> booksWithPriceSmallerThan50 = from p in products
                                                               where (p.ProductType == ProductType.Book
                                                               && p.Price < 50)
                                                               select p;
            cartWithProducts.Products.AddRange(booksWithPriceSmallerThan50);

            return cartWithProducts;
        }
        public static void DisplayItems<T>(T cartItem) where T : Cart
        {
            var sortedCartProducts = cartItem.Products.OrderBy(p => p.ProductType).ThenByDescending(p => p.Price);
            int i = 0;
            foreach (var product in sortedCartProducts)
            {
                i++;
                Console.WriteLine($"Product {i} : {product.Name} , {product.Price} , {product.ProductType}");
            }
        }
        public static bool CheckForClothesInTheCart(Cart cart)
        {
            if ((from p in cart.Products
                 where p.ProductType == ProductType.Clothes
                 select p).Count() > 0)
                return true;

            return false;
        }
        public static Product CheckForFirstElementWithPriceBiggerThan20(Cart cart)
        {
            Product product = null;

            product = cart.Products.FirstOrDefault(p => p.Price > 20);

            return product;
        }

    }
}
