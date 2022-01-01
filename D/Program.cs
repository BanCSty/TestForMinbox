using System;
using FindArea.FigureS;
namespace D
{
    public class Program
    {
        public static void Main()
        {
            Figure f = new Figure("3", 2, 3);//2,8284271247461903
            Triangle tr = new Triangle("3", 2, 3); //2,8284271247461903
            Console.WriteLine(f.GetArea());
        }
    }
}
