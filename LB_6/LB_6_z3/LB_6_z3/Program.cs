using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_6_z3
{
    internal class Program
    {
        static int IndexOf(StringBuilder str1, StringBuilder str2, int n) // Ф-ция для нахождения подстроки
        {
            int i, j;
            for (i = n; i < str1.Length;)
{
                if (str1[i] == str2[0])
                {
                    for (j = 1; j < str2.Length && i + j < str1.Length; j++)
{
                        if (str2[j] != str1[i + j])
                        {
                            break;
                        }
                    }
                    if (j == str2.Length)
                    {
                        return i;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    i++;
                }
            }
            return -1;
        }
        static void Main()
        { 
            Console.Write("Дана строка -> ");
            StringBuilder str = new StringBuilder(Console.ReadLine());

            Console.Write("Искать -> ");
            StringBuilder x = new StringBuilder(Console.ReadLine());

            int n = IndexOf(str, x, 0), kol_vo = 0; 
            while (n != -1)
            {
                kol_vo++;
                n = IndexOf(str, x, n + x.Length); // Вызов ф-ции
            }
            Console.WriteLine("Символ {0} содержится в ней {1} раз ", x, kol_vo );

            Console.ReadKey();
        }
    }
}
