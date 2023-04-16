//6.Calculate area of rectangle using multiple inheritance in C#.
using System;

namespace Lab1
{
    
        interface IShape
        {
            double GetArea();
        }

    class RectangleShape : IShape
        {
            private double length;
            private double width;

            public RectangleShape(double l, double w)
            {
                length = l;
                width = w;
            }

            public double GetArea()
            {
                return length * width;
            }
        }

        interface IDisplay
        {
            void DisplayArea(double area);
        }

        class DisplayableRectangle : RectangleShape, IDisplay
        {
            public DisplayableRectangle(double l, double w): base(l, w) { } 

            public void DisplayArea(double area)
            {
                Console.WriteLine("The area of the rectangle is: {0}", area);

            }
        }
    internal class AreaRectMultiInheritance
    {
        static void Main()
        {
            DisplayableRectangle rect = new DisplayableRectangle(5, 20);
            double area = rect.GetArea();
            rect.DisplayArea(area);

        }
    }
}
