using System;
namespace LAB7part4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TaskExecution<string> taskExecutionDelegate = task => Console.WriteLine($"Executing task: {task}");

            var scheduler = new TaskScheduler<string, int>(taskExecutionDelegate);

            while (true)
            {
                Console.WriteLine("Enter a task (or 'exit' to quit):");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine("Enter the priority:");
                if (int.TryParse(Console.ReadLine(), out int priority))
                {
                    scheduler.AddTask(input, priority);
                }
                else
                {
                    Console.WriteLine("Invalid priority. Task not added.");
                }
            }

            Console.WriteLine("Executing tasks:");
            scheduler.ExecuteNext();
            scheduler.ExecuteNext();
        }
    }
}