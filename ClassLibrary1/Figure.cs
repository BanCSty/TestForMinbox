using System;

namespace FindArea.FigureS
{
    //Class-interface for the find [area] abstract-figure 
    public class Figure : IDisposable
    {
        //Aggregation... Solution/Solution items/Extended.txt
        IArea area;

        //Circle
        public Figure(double a)
        {
            area = new Circle(a);           
        }
        //Triangle
        public Figure(string a, double b, double c)
        {
            area = new Triangle(a, b, c);
        }
        // Square
        public Figure(double a, double b)
        {
            if (a == b)
            {
                area = new Square(a, b);
            }
            //You can complicate the implementation
            else throw new ArgumentException("Это не квадрат"); 
        }

        public double Result()
        {
            return area.GetArea();
        }

        //Freeing up memory
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
