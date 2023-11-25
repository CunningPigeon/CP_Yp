using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LB_6_z2
{
    internal class Program
    {
        static void Func(int[] a, string s) 
        {
            int p = 1;

            for (int y = 0; y < a.Length; y++) // Нахождение слов, их длин и занесение значений в массив
            {
                if (s.Length != 0)
                {
                    int i = s.IndexOf(" ");
                    a[y] = i;
                    s = s.Remove(0, i + 1);
                }
                else break;


            }

            Array.Sort(a);

            for (int y = 0; y < a.Length - 1; y++) // Проверка длин слов на совпадение
            {
                if (a[y] != a[y + 1]) p = 0;
                else
                {
                    p = 1;
                    break;
                }

            }
            if (p == 1) Console.WriteLine("В строке есть слова с одинаковой длиной");
            else Console.WriteLine("длина всех слов разная");

            foreach (int i in a)
            {
                Console.Write(i);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите кол-во слов -> ");
            int kol_vo = int.Parse(Console.ReadLine()); // Ввод данных

            Console.Write("Введите строку -> ");
            StringBuilder stroka = new StringBuilder(Console.ReadLine());

            
            string k = stroka.ToString() + " ";
            
            int[] myArray = new int[kol_vo]; // Инициализация массива

            Func(myArray, k);

            //Console.WriteLine(k);


            Console.ReadKey();
        }
    }
}
