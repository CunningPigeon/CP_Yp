using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LB_4_z2
{
    internal class Program
    {
        static void Func()
        {
            int n = int.Parse(Console.ReadLine()); // Ввод числа
            int h = 0, nh = 0;
            while (n != 0) 
            {
                if (n % 2 == 0) //Проверка цифры числа на чет/нечет
                {
                    h++;
                }
                else nh++;
                n /= 10;
            }
            Console.WriteLine("Четных -> {0} \nНечетных -> {1}", h, nh);
        }
        static void Main(string[] args)
        {
            Console.Write("Кол-во чисел -> ");
            int k = int.Parse(Console.ReadLine());
            int i = 0;

            Console.WriteLine("Числа -> ");
            while (i < k)
            {
                Func(); // Вызов ф-ции
                i++; // Увеличиваем на 1
            }


            Console.ReadKey();
        }
    }
}
