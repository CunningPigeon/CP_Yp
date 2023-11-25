using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_9
{
    internal class Program
    {
        class cArray
        {
            public int[,] Array;

            public cArray(int rows, int column) // Конструктор(1) создает массив размерностью nxm
            {
                int[,] Array = new int[rows, column];

            }

            public Write()
            {
                int rows = .GetLength(0);
                int column = .GetLength(1);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write($"{Array[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }
                
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность друмерного массива ->");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());


            cArray oneCircle = new cArray(n, m); //вызов конструктора(1)

            Console.ReadKey();
        }
    }
}
