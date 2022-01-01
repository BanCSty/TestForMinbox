using System;
using FindArea.FigureS.Interfaces;

namespace FindArea.FigureS
{
    class Square : IDisposable, IArea
    {
        private double _a;
        private double _b;

        public Square(double a, double b)
        {
            try
            {
                A = a;
                B = b;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Значени должно быть больше нуля!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }

        public double A
        {
            get { return _a; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                _a = value;
            }
        }
        public double B
        {
            get { return _b; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                _b = value;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public double GetArea()
        {
            return _a * _b;
        }
    }
}
