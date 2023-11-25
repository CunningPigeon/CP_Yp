using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("({0:.##} + {1:.##}) + {2:.##} = {0:.##} + ({1:.##} + {2:.##})", a, b, c); // {0:.##} – форматированный вывод

            Console.ReadKey();

        }
    }
}
