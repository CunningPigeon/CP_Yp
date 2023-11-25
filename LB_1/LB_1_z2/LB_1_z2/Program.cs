using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1_z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите площадь полной поверхности куба = ");
            int S = int.Parse(Console.ReadLine());

            double a = Math.Sqrt(S/6);
            Console.Write("Ребро куба = {0:.##}", a);
            Console.ReadKey();
        }
    }
}
