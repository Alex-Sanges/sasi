using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A aa = new A();
            A aaa = new A();
            B b = new B();
            C c = new C();
            //create circuls
            b.a1 = a;
            c.a2 = aa;
            c.a3 = aaa;
            c.b1 = b;
            c.a1 = a;
        }
    }
}
