using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_3_z3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = "); // Ввод данных
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("h = ");
            float h = float.Parse(Console.ReadLine());
            float y;

            
            while (a <= b) // Цикл для диапозона
            {
                float x = a;

                if ((x * x + 2 * x + 1) < 2) // Проверка условия
                {
                    y = x * x;
                    Console.WriteLine("x = {0}  y = {1:.####}", x, y);
                }
                else if (((x * x + 2 * x + 1) >= 2) || ((x * x + 2 * x + 1) < 3))
                {
                    y = 1 / (x * x - 2);
                    Console.WriteLine("x = {0}  y = {1:.####}", x, y);
                }
                else
                {
                    y = 0;
                    Console.WriteLine("x = {0}  y = {1:.####}", x, y);
                }
                a += h;
            }
            Console.ReadKey();
        }
    }
}
