using System.Collections.Generic;
using System.Linq;

namespace LAB5part1
{
    public class Order
    {
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        public Order(List<Product> products, int quantity)
        {
            Products = products;
            Quantity = quantity;
            TotalPrice = CalculateTotalPrice();
            Status = "Pending";
        }

        private decimal CalculateTotalPrice()
        {
            return Products.Sum(p => p.Price) * Quantity;
        }
    }
}