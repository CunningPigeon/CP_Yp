using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_6_oz_2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку:");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < a.Length;) //удаляем из строк все знаки пунктуации
            {
                if (char.IsPunctuation(a[i]) || a[i] == ' ' && a[i - 1] == ' ')
                {
                    a.Remove(i, 1);
                }
                else ++i;
            }
            //преобразуем объект StringBuilder к типу string, и разбиваем его на массив слов
            string[] s = a.ToString().Split(' ');
            Console.WriteLine("Искомые слова:");
            //перебираем все слова в массиве слов и выводим на экран те, которые
            //начинаются и заканчиваются на одну и туже букву
            foreach (string str in s)
            {
                if (str[0] == str[str.Length - 1])

                    Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
