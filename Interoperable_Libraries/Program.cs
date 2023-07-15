using System;
//using Geometry;
using Graphics;

namespace DrawLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new(20, 20);
            Point point2 = new(0, 0);

            Line line = new(point1, point2);
            ConsoleColor color = ConsoleColor.Green;

            ColoredLine coloredLine = new(line, color);
            coloredLine.DrawLine();
        }
    }
}