using System;
namespace Testing
{
    public  class S_Figure
    {
        private  double _Square;
        private  bool _rectangular = false;

        public  double Square(double a, double b, double c)

        {

            double _max = Math.Max(a, Math.Max(b, c));


            if (_max == a)
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                    _rectangular = true;
            _Square = b * c;

            if (_max == b)
                if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                    _rectangular = true;
            _Square = a * c;

            if (_max == c)
                if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                    _rectangular = true;
            _Square = a * b;


            if (!_rectangular)
            {
                double _p = (a + b + c) / 2;

                _Square = Math.Sqrt(_p * (_p - a) * (_p - b) * (_p - c));
            }
            return _Square;
        }
        public double Square(double radius)
        {
            return _Square = Math.PI * radius * radius;
        }



    }
}
