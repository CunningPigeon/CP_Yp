using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_6_oz_1
{
    internal class Program
    {
        static void Main()
        {
            string poems = "тучки небесные вечные странники";
            char[] div = { ' ' }; //создаем массив разделителей
                                  // Разбиваем строку на части,
            string[] parts = poems.Split(div);
            Console.WriteLine("Результат разбиения строки на части: ");
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }
            string revers = string.Empty;
            for (int i = parts.Length - 1; i > -1; i--)
            {
                revers += parts[i] + "|";
            }
            string whole = String.Join("| ", revers);
            Console.WriteLine("Результат сборки: ");

            Console.WriteLine(whole);

            Console.ReadKey();
        }
    }
}
