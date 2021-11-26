using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lavrinenko
{
    interface LogInterface
    {
        LogInterface log(string str);
        LogInterface write();
    }
}
