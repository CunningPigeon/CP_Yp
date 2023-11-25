using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_5_z2
{
    internal class Program
    {
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
{
                for (int j = 0; j < a.GetLength(1); j++)
{
                    Console.Write("{0} ", a[i, j]); // Выводим массив
                }
                Console.WriteLine();
            }
        }

        static void Input(out int[,] a)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            a = new int[n, n];
            for (int i = 0; i < a.GetLength(0); i++) // Проходим массив (строки)
{
                for (int j = 0; j < a.GetLength(1); j++) // Проходим массив (столбцы)
                {
                    Console.Write(" a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine()); // Заполняем массив
                }
            }
        }

        static void F(int[,] a)
        {

            int n = a.GetLength(0)-1, k = 0;
            for (int i = 0; i < a.GetLength(0); i++)
{
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    
                    if (i == j) // Проверям на гл. диагональ и меняем с побочной
                    {
                        k = a[i, j]; 
                        a[i, j] = a[i, n - i];
                        a[i, n - i] = k;
                    } 
                }
            }
        }

        static void Main()
        {
            int[,] a;
            Input(out a);
            Console.WriteLine("Исходный массив: ");
            Print(a);
            F(a);
            Console.WriteLine("Измененный массив: ");
            Print(a);



            Console.ReadKey();
        }
    }
}
