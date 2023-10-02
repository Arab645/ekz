using System;
namespace LAB2part4
{
    public class User
    {
        private string Login;
        private string Name;
        private string Lastname;
        private int Age;
        private readonly DateTime registrationDate;
        
        public User (string login, string name, string lastname, int age)
        {
            Login = login;
            Name = name;
            Lastname = lastname;
            Age = age;
            registrationDate = DateTime.Now;
        }
        public void DisplayUserInfo()
        {
            Console.WriteLine("User Information:");
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"First Name: {Name}");
            Console.WriteLine($"Last Name: {Lastname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Registration Date: {registrationDate}");
        }
    }
}