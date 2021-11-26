using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lavrinenko
{
    /*class LogAbstract
    {
    }*/
    abstract public class LogAbstract
    {
        public string for_Log(String[] strings)
        {
            return formatLog(strings);
        }
        protected /*String*/string formatLog(String[] strings)
        {
            //return strings + ";";
            return String.Join(";", strings);

        }

        protected void writeConsole(String s)
        {
            Console.WriteLine(s);
            //System.out.println(s);
        }

        protected void writeConsole(String[] s)
        {
            Console.WriteLine(formatLog(s));
            //System.out.println(formatLog(s));
        }

    }
}
