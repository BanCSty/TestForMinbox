using System;
using FindArea.FigureS.Interfaces;

namespace FindArea.FigureS
{
    //Class-interface for the find [area] abstract-figure 
    public class Figure : IDisposable,  IExtensionInterface
    {
        //Since not all shapes can be rectangular, I made three interfaces
        //IArea - for calculating the area of ​​shapes
        //IsRectengular - is a triangle right-angled
        //IExtensionInterface - an intermediary interface providing common functionality from other interfaces
        IArea iarea;
        IsRectengular isrec;

        //Circle
        public Figure(double a)
        {
            iarea = new Circle(a);           
        }
        //Triangle
        public Figure(string a, double b, double c)
        {
            isrec = new Triangle(a, b, c);
            iarea = isrec;        
        }
        // Square
        public Figure(double a, double b)
        {
            if (a == b)
            {
                iarea = new Square(a, b);
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
            return iarea.GetArea();
        }

        public bool IsRectengular()
        {
            return isrec.IsRectengular();
        }
    }
}
