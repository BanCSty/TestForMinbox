using FindArea.FigureS.Interfaces;
using System;


namespace FindArea.FigureS
{
    public class Triangle : IDisposable, IsRectengular
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(string a,double b, double c)
        {
            try
            {
                _a = Convert.ToDouble(a); //Only for the check
                //_a = a;
                _b = b;
                _c = c;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Value must be more than zero");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public double A 
        { 
            get { return _a; } 
            set { if (value <= 0) throw new ArgumentOutOfRangeException(); _a = value;}
        }
        public double B 
        { 
            get { return _b; }
            set { if (value <= 0) throw new ArgumentOutOfRangeException(); _b = value; }
        }
        public double C 
        {
            get { return _c; }
            set { if (value <= 0) throw new ArgumentOutOfRangeException(); _c = value; }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public double GetArea()
        {
            double p;
            p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRectengular()
        {
            //If performed Pifagor teorem: 
            // с²= a²+b² , where c -max side, а and b the two other, – triangle is rectangular.

            double mx;
            //Find max side
            mx = _a;
            if (_b > mx) mx = _b;
            if (_c > mx) mx = _c;

            if (mx == _a)
            {
                if (mx * mx == (_b * _b) + (_c * _c)) return true;
            }
            else if (mx == _b)
            {
                if (mx * mx == _a * _a + _c * _c) return true;
            }
            else
            {
                if (mx * mx == _a * _a + _b * _b) return true;
            }
            return false;
        }
    }
}
