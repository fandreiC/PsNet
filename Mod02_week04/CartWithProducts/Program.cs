using System;

namespace CartWithProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            DoCartJob();
            Console.ReadKey();
        }

        private static void DoCartJob()
        {
            var cart = ManipulateItems.Populate();

            ManipulateItems.DisplayItems(cart);

            string areClothes = "are not";
            if (ManipulateItems.CheckForClothesInTheCart(cart)) { areClothes = "are"; }
            Console.WriteLine($"There {areClothes} clothes in this cart");

            Product product = ManipulateItems.CheckForFirstElementWithPriceBiggerThan20(cart);

            if (product is null)
                Console.WriteLine("There are no products that match your criteria");
            else
                Console.WriteLine($"First product matching your criteria is {product.Name}");

        }
    }
}
