using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1_z3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A = ");
            int A = int.Parse(Console.ReadLine()); //Вводим число А

            Console.Write("Введите число N = ");
            int N = int.Parse(Console.ReadLine());

            int x = N / 10; // Находим десяток
            int y = N % 10; // Находим единицы
            Console.WriteLine("{0}, {1}", x, y);

            string result = ((x + y) % A == 0) ? "True" : "False"; // Проверяем кратность числу А
            Console.Write(result);
            Console.ReadKey();

        }
    }
}
