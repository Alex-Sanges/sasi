using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lavrinenko
{
    abstract public class LogAbstract
    {
        public string for_Log(String[] strings)
        {
            return formatLog(strings);
        }
        protected string formatLog(String[] strings)
        {
            return String.Join(";", strings);

        }

        protected void writeConsole(String s)
        {
            Console.WriteLine(s);
        }

        protected void writeConsole(String[] s)
        {
            Console.WriteLine(formatLog(s));
        }

    }
}
