using System;
using ConsoleApp3.zhitie_moe;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lavrinenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Get get = new Get();
            QuadEquations Quad = new QuadEquations();
            //LogAbstract sas = new LogAbstract();
            //var suck_static = new AlexeyLog();
            //s
            try
            {
                //
                Console.WriteLine("Введите 3 параметра a, b и с");
                List<double> solve=Quad.solve(get.number(), get.number(), get.number());
                if (solve.Count > 0)
                {
                    AlexeyLog.I().log("корни уравнения");
                    foreach (double x in solve)
                        AlexeyLog.I().log(String.Join(" x= ", x));
                        // AlexeyLog.I().log()
                        //LogAbstract().for_Log();

                }
            }
            catch (/*InvalidCastException e*/MynameException ex)
            {
                //string E = Convert.ToString(e);
                AlexeyLog.I().log(Convert.ToString(ex)/*E*/);
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            //
            AlexeyLog.I().write();
            Console.ReadKey();
        }
    }
}
