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
                if ((a[i] > a[i + 1]) && (a[i] > a[i - 1]) || ((i == a.Length - 2) && (a[i] < a[i + 1]))) n++; // Нахождение групп

            }
            return n;
        }

        static int[] DeleteGroup(int[] a)
        {
            int beg = -1, end = -1;
            for (int i = 1; i < a.Length - 1; ++i)
            {
                if (beg == -1)
                {
                    if (a[i] < a[i + 1])
                    {
                        beg = i;
                        if ((a[i] > a[i - 1]) && (i == 1))
                        {
                            beg--;
                        }
                    }
                }

                if (end == -1)
                {
                    if (((a[i] > a[i + 1]) && (a[i] > a[i - 1]) )||((i == a.Length - 2) && (a[i] < a[i + 1])))
                    {
                        end = i;
                        if ((i == a.Length - 2)&&(a[i] < a[i + 1])){
                            end++;
                        }
                    }
                }





                }
            Console.WriteLine("beg = {0} end = {1}", beg, end);
            // Удаление элементов из массива
            int newLength = 0;
            int[] newArray = new int[a.Length];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((i < beg) || (i > end))
                {
                    newLength++;
                    newArray[j] = a[i];
                    j++;
                }
                
            }
            Array.Resize(ref newArray, newLength);
            a = newArray;

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }


            return a;
        }
        static void Main(string[] args)
        {
            int[] mass = Input(); // Вызов ф-ции ввода
            Console.WriteLine("Кол-во групп =  {0}", Search(mass));
            
            DeleteGroup(mass);

            Console.ReadKey();

        }
    }
}
