using System;
//using Geometry;

namespace Graphics;
public class ColoredLine
{
    private readonly Line line;
    private readonly ConsoleColor color;

    public ColoredLine(Line line, ConsoleColor color)
    {
        this.line = line;
        this.color = color;
    }

    public void DrawLine()
    {
        var deltaX = Math.Abs(this.line.EndPoint.X - this.line.StartPoint.X);
        var deltaY = Math.Abs(this.line.EndPoint.Y - this.line.StartPoint.Y);

        var slope = (double)deltaY / deltaX;
        var currentY = 5.2;

        if ((double)this.line.StartPoint.Y > (double)this.line.EndPoint.Y)
            currentY = (double)this.line.EndPoint.Y;
        else
            currentY = (double)this.line.StartPoint.Y;

        Console.ForegroundColor = this.color;
        int xStart = 1;
        int xEnd = 1;

        if ((double)this.line.StartPoint.X > (double)this.line.EndPoint.X)
        {
            xStart = this.line.EndPoint.X;
            xEnd = this.line.StartPoint.X;
        }
        else
        {
            xStart = this.line.StartPoint.X;
            xEnd = this.line.EndPoint.X;
        }

        for (var x = xStart; x <= xEnd; x++)
        {
            var roundedY = (int)Math.Round(currentY);
            Console.SetCursorPosition(x, roundedY);
            Console.Write("■");

            currentY += slope;
        }
    }
}
