namespace LAB8part2
{
    using System;

    public abstract class GraphFactory
    {
        public abstract Graph CreateGraph();
    }

    public class LineGraphFactory : GraphFactory
    {
        public override Graph CreateGraph()
        {
            return new LineGraph();
        }
    }

    public class BarGraphFactory : GraphFactory
    {
        public override Graph CreateGraph()
        {
            return new BarGraph();
        }
    }

    public class PieChartFactory : GraphFactory
    {
        public override Graph CreateGraph()
        {
            return new PieChart();
        }
    }
}