using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rattional
{
    public struct Rational
    {
        private int _numerator;
        private int _denominator;
        public int Numerator { get { return _numerator; } set { _numerator = value; } }
        public int Denominati

        public Rational(int numerator,int denominator )
        {
            _numerator = numerator;
            _denominator = denominator;
        }
    }
}
