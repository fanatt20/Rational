using System;

namespace RationalMath
{
    public struct Rational
    {
        private static double _eps = 0.000001;
        private int _denominator;

        public Rational(int numerator, int denominator = 1)
            : this()
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static double Eps
        {
            get { return _eps; }
            set
            {
                if(value <= 0)
                    throw new ArgumentOutOfRangeException("Eps must be non negative");
                _eps = value;
            }
        }

        public int Numerator { get; set; }

        public int Denominator
        {
            get
            {
                if(_denominator == 0)
                    _denominator = 1;
                return _denominator;
            }
            set
            {
                if(value == 0)
                    throw new DivideByZeroException();
                _denominator = value;
            }
        }

        public double ToDouble()
        {
            return Numerator / Denominator;
        }

        public static implicit operator double(Rational val)
        {
            return val.Numerator / val.Denominator;
        }

        public static explicit operator float(Rational val)
        {
            return val.Numerator / val.Denominator;
        }

        public static explicit operator int(Rational val)
        {
            return val.Numerator / val.Denominator;
        }
        
        public static bool operator ==(Rational val, double other)
        {
            return Math.Abs(other - val) <= Eps;
        }

        public static bool operator !=(Rational val, double other)
        {
            return Math.Abs(other - val) > Eps;
        }

        public static bool operator >(Rational val, double other)
        {
            return val > other;
        }

        public static bool operator <(Rational val, double other)
        {
            return val < other;
        }
    }
}