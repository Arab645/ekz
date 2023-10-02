using System;
namespace LAB2part3
{
    public class Employee
    {
        private string lastName;
        private string Name;
        private string position;
        private double salary;
        private int experience;

        public Employee(string lastName, string Name)
        {
            this.lastName = lastName;
            this.Name = Name;
        }

        public void SetPosition(string position)
        {
            this.position = position;
        }

        public void SetExperience(int experience)
        {
            this.experience = experience;
        }

        public void CalculateSalaryAndTax()
        {
            double baseSalary = 0;

            switch (position.ToLower())
            {
                case "manager":
                    baseSalary = 238457884;
                    break;
                case "hr":
                    baseSalary = 2374732;
                    break;
                case "security":
                    baseSalary = 232523;
                    break;
                default:
                    Console.WriteLine("Unknown post");
                    return;
            }
            if (experience >= 5)
            {
                salary = baseSalary * 1.2;
            }
            else
            {
                salary = baseSalary;
            }
            double tax = salary * 0.2;
            Console.WriteLine("Information about worker:");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Tax: {tax}");
        }
    }
}