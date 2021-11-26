using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class A
    {
        protected double x = 0;
        protected double LineEquation(double a, double b)
        {
            if(a==0) throw new Exception("Определено, что Марк лох, а ещё это не линейное уравнение");
            return x = -b / a;
        }
    }
}
