namespace LAB2part3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Dan", "josh");
            employee.SetPosition("hr");
            employee.SetExperience(7);
            employee.CalculateSalaryAndTax();
        }
    }
}