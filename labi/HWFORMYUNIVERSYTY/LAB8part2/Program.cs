using System;
namespace LAB8part2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a graph type to visualize (Line/Bar/Pie):");
            string graphType = Console.ReadLine().ToLower();

            GraphFactory factory = null;

            switch (graphType)
            {
                case "line":
                    factory = new LineGraphFactory();
                    break;
                case "bar":
                    factory = new BarGraphFactory();
                    break;
                case "pie":
                    factory = new PieChartFactory();
                    break;
                default:
                    Console.WriteLine("Invalid graph type");
                    return;
            }

            Graph graph = factory.CreateGraph();
            graph.Draw();
        }
    }
}