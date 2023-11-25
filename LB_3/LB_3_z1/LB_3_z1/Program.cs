using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_3_z1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x -> ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y -> ");
            int y = int.Parse(Console.ReadLine());

            while (x <= y)
            {
                if (x % 2 == 0) Console.Write(x + " ");  // Проверка на четность, вывод
                x++;
            }
            Console.ReadKey();

        }
    }
}
