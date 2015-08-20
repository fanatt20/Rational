using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rattional
{
    public struct Rational
    {
        private int _numerator;
        private int _denominator;
        public int Numerator { get { return _numerator; } set { _numerator = value; } }
        public int Denominator {get { if (_denominator == 0) _denominator = 1;
            return _denominator;
        }
        set{if (value==0) throw new DivideByZeroException();
            _denominator = value;
        }}

        public Rational(int numerator,int denominator )
        {
            _numerator = numerator;
            if (denominator==0)
                throw new DivideByZeroException();
            _denominator = denominator;
        }
    }
}
