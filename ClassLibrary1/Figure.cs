using System;
using FindArea.FigureS.Interfaces;

namespace FindArea.FigureS
{
    //Class-interface for the find [area] abstract-figure 
    public class Figure : IDisposable, Iarea_IisRectengular
    {
        //Aggregation... Solution/Solution items/Extended.txt
        Iarea_IisRectengular test;

        //Circle
        public Figure(double a)
        {
            test = new Circle(a);           
        }
        //Triangle
        public Figure(string a, double b, double c)
        {
            test = new Triangle(a, b, c);
            
        }
        // Square
        public Figure(double a, double b)
        {
            if (a == b)
            {
                test = new Square(a, b);
            }
            //You can complicate the implementation
            else throw new ArgumentException("Это не квадрат"); 
        }

        //Freeing up memory
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public double GetArea()
        {
            return test.GetArea();
        }

        public bool IsRectengular()
        {
            return test.IsRectengular();
        }
    }
}
