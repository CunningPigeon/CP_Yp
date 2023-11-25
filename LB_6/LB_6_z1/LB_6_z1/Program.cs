using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_6_z1
{
    internal class Program
    {
        static void Search(string str)
        {
            int i = 0;
            string stroka2 = "";
            while (i < str.Length)
            {
                if (str.IndexOf(str[i]) == str.LastIndexOf(str[i])) stroka2 += str[i]; // Проверка на единичность
                i++;
            }
               
            Console.WriteLine("Буквы -> {0}", stroka2); // Вывод строки
        }

        static void Main(string[] args)
        {
            Console.Write("Введите строку -> ");
            string stroka = Console.ReadLine();
            Search(stroka); // Вызов ф-ции

            Console.ReadKey();
        }
    }
}
