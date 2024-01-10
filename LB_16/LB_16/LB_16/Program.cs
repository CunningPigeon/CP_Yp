using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyLibrary;

namespace LB_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кол-во чисел -> ");
            int k = int.Parse(Console.ReadLine());
            int i = 0;

            Console.WriteLine("Числа -> ");
            while (i < k)
            {
                MyLibrary.Class1.Func(); // Вызов ф-ции
                i++; // Увеличиваем на 1
            }

            Console.ReadKey();
        }
    }
}

