using System;
using FindArea;
using FindArea.FigureS;

namespace DAs
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractFigure a = new Circle(12);
            //double r = a.GetArea();
            //Console.WriteLine(r);

            //Triangle b = new Triangle(0, 3, 4);
            //Console.WriteLine(b.IsRectengular());

            IArea test = new Circle((int)'D');
            Console.WriteLine(test.GetArea());

            IArea test2 = new Triangle("`", 4, 5);
            //Console.WriteLine((Triangle2)test2.IsRectengular());
            Console.ReadKey();
               
        }
    }
}
