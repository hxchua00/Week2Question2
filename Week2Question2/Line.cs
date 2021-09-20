using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Question2
{
    class Line
    {
        public struct Startpoint
        {
            public static int X1 { get; set; }
            public static int Y1 { get; set; }

            public Startpoint(int x, int y)
            {
                x = X1;
                y = Y1;
            }
        }
        public struct Endpoint
        {
            public static int X2 { get; set; }
            public static int Y2 { get; set; }

            public Endpoint(int x, int y)
            {
                x = X2;
                y = Y2;
            }
        }

        public void Display()
        {
            Line.Startpoint.X1 = 10;
            Line.Startpoint.Y1 = 20;
            Line.Endpoint.X2 = 20;
            Line.Endpoint.Y2 = 40;

            Console.WriteLine("Starting point X: " + Line.Startpoint.X1);
            Console.WriteLine("Starting point Y: " + Line.Startpoint.Y1);
            Console.WriteLine();
            Console.WriteLine("Starting point X: " + Line.Endpoint.X2);
            Console.WriteLine("Starting point Y: " + Line.Endpoint.Y2);
        }

        public void slope()
        {
            int slope = (Line.Endpoint.Y2 - Line.Startpoint.Y1) / (Line.Endpoint.X2 - Line.Startpoint.X1);
            Console.WriteLine("The slope of the line is: " + slope);
        }
    }
}
