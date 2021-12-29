using System;
using FindArea;
using FindArea.FigureS;
using FindArea.FigureS.Interfaces;


namespace Da
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figure f = new Figure("1", 2, 3);
            Figure a = new Figure(2,3);
            
            Console.WriteLine(a.GetArea());
            //Console.WriteLine(a.IsRectengular());
        }
    }
}
