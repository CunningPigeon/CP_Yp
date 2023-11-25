using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()); 
            if (4 - x * x > 0) // Проверка условия
            {
                double y = Math.Log10(4 - (x * x)); // Вычисление фун-ции
                Console.WriteLine("y = ln(4 - x*x) = {0:0.####}", y);
                
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();

        }
    }
}
