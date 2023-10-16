using System.Collections.Generic;

namespace LAB5part1
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Order> PurchaseHistory { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            PurchaseHistory = new List<Order>();
        }
    }
}