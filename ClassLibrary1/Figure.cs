using System;

namespace FindArea.FigureS
{
    //Класс-интерфейс для поиска площади неопределённых фигур
    public class Figure : IDisposable
    {
        //Агрегация... Solution/Solution items/Extended.txt
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
            else throw new ArgumentException("Это не квадрат"); //Здесь можно передать вызов другому ctor
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
