using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(); // [0 - 2^31) случайные числа

            try
            {
                Console.WriteLine(array[6]);
            }
            catch  (Exception ex) // исключение
            {
                Console.WriteLine("Взникло исключение: {0}", ex.Message); // полкчение наименования ошибки и ее вывод
            }
            

            try
            {
                int j = 11, ii = 60;
                while (j >= -10)
                {
                    Console.WriteLine("i= {0}, j={1}", ii, j);
                    ii += 3;
                    j--;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Взникло исключение: {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
