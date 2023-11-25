using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_5_z1._1
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
        static int Multiplicity(int[] a)
        {
            int k = 0;
            foreach (int elem in a)
            {
                if (elem % 2 == 0) k++; // Проверяем кратность числу
            }
            return k;
        }

        static void Main(string[] args)
        {

            int[] mass = Input(); //Вызов ф-ции
            Console.Write("Введите число = ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Кол-во кратных числу {0} = {1}", k, Multiplicity(mass));



            Console.ReadKey();
        }
    }
}
