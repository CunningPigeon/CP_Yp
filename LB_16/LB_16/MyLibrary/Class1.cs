using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Class1
    {
        public static void Func()
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
    }
}