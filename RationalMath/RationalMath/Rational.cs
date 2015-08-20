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
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Eps must be non negative");
                _eps = value;
            }
        }

        public int Numerator { get; set; }

        public int Denominator
        {
            get
            {
                if (_denominator == 0)
                    _denominator = 1;
                return _denominator;
            }
            set
            {
                if (value == 0)
                    throw new DivideByZeroException();
                _denominator = value;
            }
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }

        public static explicit operator Rational(string value)
        {
            var arr = value.Split('/');
            var numerator = 0;
            var denominator = 0;
            if (arr.Length != 2)
            {
                if (arr.Length == 1 && int.TryParse(arr[0], out numerator))
                    return new Rational(numerator);

                throw new InvalidCastException();
            }

            if (!int.TryParse(arr[0], out numerator) || !int.TryParse(arr[1], out denominator))
                throw new InvalidCastException();
            return new Rational(numerator, denominator);
        }

        public static Rational operator +(Rational val, Rational other)
        {
            return new Rational(val.Numerator*other.Denominator + val.Denominator*other.Numerator,
                val.Denominator*other.Denominator);
        }

        public static Rational operator -(Rational val, Rational other)
        {
            return new Rational(val.Numerator*other.Denominator - val.Denominator*other.Numerator,
                val.Denominator*other.Denominator);
        }

        public static Rational operator *(Rational val, Rational other)
        {
            return new Rational(val.Numerator*other.Numerator, val.Denominator*other.Denominator);
        }

        public static Rational operator /(Rational val, Rational other)
        {
            return new Rational(val.Numerator*other.Denominator, val.Denominator*other.Numerator);
        }

        public static explicit operator double(Rational val)
        {
            return val.Numerator/val.Denominator;
        }

        public static explicit operator float(Rational val)
        {
            return val.Numerator/val.Denominator;
        }

        public static explicit operator int(Rational val)
        {
            return val.Numerator/val.Denominator;
        }

        public static bool operator ==(Rational val, Rational other)
        {
            return val.Numerator == other.Numerator && val.Denominator == other.Denominator;
        }

        public static bool operator !=(Rational val, Rational other)
        {
            return val.Numerator != other.Numerator || val.Denominator != other.Denominator;
        }
    }
}