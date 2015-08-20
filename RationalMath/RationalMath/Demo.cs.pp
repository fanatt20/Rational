using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  RationalMath;

namespace $rootnamespace$
{
     class Demo
     {
         public void HowToUse()
         {
             var number1 = new Rational(25, 3);
             var number2 = new Rational(-133, 12);
             var number3 = new Rational(3);   

             var sum = number1 + number2;
             var minus = number1 - number2;
             var div = number1 / number2;
             var mul = number2*number1;
             var doub = (double) minus;
         }


     }
}
