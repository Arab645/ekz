using System;
using System.Collections.Generic;
namespace LAB5part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var store = new Store();

            var user1 = new User("user1", "password1");
            var user2 = new User("user2", "password2");

            var product1 = new Product("Product 1", 10.99m, "Description 1", "Category A", 4);
            var product2 = new Product("Product 2", 19.99m, "Description 2", "Category B", 5);
            var product3 = new Product("Product 3", 5.99m, "Description 3", "Category A", 3);

            store.AddUser(user1);
            store.AddUser(user2);
            store.AddProduct(product1);
            store.AddProduct(product2);
            store.AddProduct(product3);

            var affordableProducts = store.SearchByPrice(15.00m);
            var categoryAProducts = store.SearchByCategory("Category A");
            var highlyRatedProducts = store.SearchByRating(4);

            foreach (var product in affordableProducts)
            {
                Console.WriteLine($"Affordable product: {product.Name}");
            }

            foreach (var product in categoryAProducts)
            {
                Console.WriteLine($"Category A product: {product.Name}");
            }

            foreach (var product in highlyRatedProducts)
            {
                Console.WriteLine($"Highly rated product: {product.Name}");
            }
        }
    }
}