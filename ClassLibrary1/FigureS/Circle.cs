using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindArea.FigureS
{

    public class Circle : IArea, IDisposable
    {
        private double _value;

        public Circle(double value)
        {
            try
            {
                Value = value;
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

        //Хоть рихтер и против, но...
        //Value must be more then zero, i think so...
        public double Value { get { return _value;} 
            set {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                _value = value;
            } 
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public double GetArea()
        {
            return (_value * _value * Math.PI);
        }
    }
}
