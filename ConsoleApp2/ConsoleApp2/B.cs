using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp2
{
    class B:A
    {
        protected double x2;
        protected List<double> QuadEquation(double a, double b, double c)
        {
            List<double> ArrX = new List<double>();
            if(a==0)
            {
                ArrX.Add(LineEquation(b,c));
            }
            //double DesCream= Math.Pow(b, 2) - 4 * a * c;
            //string sas;
            double desk = DesCream(a, b, c);
            if (desk == 0)
            {
                x = -(b / (2 * a));
            }
            if (desk > 0) {
                x = (-b + Math.Sqrt(desk)) / (2*a);
                x2 = (-b - Math.Sqrt(desk)) / (2 * a);
                //sas = "x1 = ";sas += x;sas += " x2 = "; sas+=x2;
                ArrX.Add(x);
                ArrX.Add(x2);
            }
 //x = -b / a; a*x^2+b*x=-c
            else
           {
                throw new Exception("Определено, а ещё это не квадратное уравнение");
                //ничего не добавляем в лист
                //корней нет 
            }
            return ArrX;
        }
        protected double DesCream(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
