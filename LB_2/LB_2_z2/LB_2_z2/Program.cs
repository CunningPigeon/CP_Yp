using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_2_z2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write(" x = "); // Ввод данных
            double x = double.Parse(Console.ReadLine());
            Console.Write(" y = ");
            double y = double.Parse(Console.ReadLine());

            if ((x < 0 && y < 0) || (x * x + y * y > 1)) // Проверка на непринадлежность
            { 
                Console.WriteLine("Нет");
            }
            else if (x * x + y * y < 1) // Проверка на принадлежность
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Граница"); // Проверка на границу
            }
            Console.ReadKey();  



        }
    }

}

