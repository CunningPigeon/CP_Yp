using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_3_z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 4;

            for (int i = y; i >= 0; i--) // Цикл для столбца
            {
                for (int j = y; j >= 0; j--) // Цикл для строки
                {
                    Console.Write(j + " "); // Вывод строки

                }
                y--;
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
