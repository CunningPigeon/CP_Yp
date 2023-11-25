using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_5_z1._2
{
    internal class Program
    {
        static int[] Input()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write("a[{0}]= ", i);  // Ввод массива
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static int Search(int[] a)
        {
            int n = 0;

            for (int i = 1; i < a.Length-1; ++i)
            {
                if ((a[i] > a[i + 1]) && (a[i] > a[i - 1])) n++; // Нахождение групп

            }
            return n;
        }

        static void DeleteGroup(int[] a)
        {
            int n = 0;
            while (n <= 2)
            {
                for (int i = 1; i < a.Length - 1; ++i)
                {
                    if ((a[i] > a[i + 1]) && (a[i] > a[i - 1])) n++; // Нахождение групп

                }
            }
            
        }
        static void Main(string[] args)
        {
            int[] mass = Input(); // Вызов ф-ции ввода
            Console.WriteLine("Кол-во групп =  {0}", Search(mass));
            
            DeleteGroup(mass);
            Console.WriteLine("Удаление 1-ой группы =  {0}");



            Console.ReadKey();

        }
    }
}
