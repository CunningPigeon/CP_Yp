using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_4_z1
{
    internal class Program
    {
        static void Func(int x)
        {
            int y = x % 10;
            x = x / 10;
            Console.WriteLine("Число -> {0}", y * 10 + x);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число -> ");
            int x = int.Parse(Console.ReadLine());

            if ((x >= -99 && x <= -10) || (x <= 99 && x >= 10)) // Проверяем, двузначное ли число
            {
                Func(x); // Вызываем метод
            }
            else Console.WriteLine("Число -> {0}", x);

            Console.ReadKey();
        }
    }
}
