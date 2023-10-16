using System;
using System.Collections.Generic;
using System.Linq;
namespace LAB5part1
{
    public class Store : ISearchable
    {
        public List<User> Users { get; }
        public List<Product> Products { get; }
        public List<Order> Orders { get; }

        public Store()
        {
            Users = new List<User>();
            Products = new List<Product>();
            Orders = new List<Order>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void CreateOrder(User user, List<Product> products, int quantity)
        {
            var order = new Order(products, quantity);
            user.PurchaseHistory.Add(order);
            Orders.Add(order);
        }

        public List<Product> SearchByPrice(decimal maxPrice)
        {
            return Products.Where(p => p.Price <= maxPrice).ToList();
        }

        public List<Product> SearchByCategory(string category)
        {
            return Products.Where(p => p.Category == category).ToList();
        }

        public List<Product> SearchByRating(int minRating)
        {
            return Products.Where(p => p.Rating >= minRating).ToList();
        }
    }
}