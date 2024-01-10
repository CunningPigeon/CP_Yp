using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LB_9
{
    internal class Program
    {
        class cArray
        {
            public int[,] Array = null;
            public int rows = 0, column = 0;

            public cArray(int rows, int column) // Конструктор(1) создает массив размерностью nxm
            {
                Array = new int[rows, column];
                this.rows = rows;
                this.column = column;   

            }

            public void Input() // Ввож массива
            {
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        Console.Write($"Элемент [{i},{j}] -> ");
                        Array[i, j] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
            }

            // int[,]
            public void Write() // Вывод массива
            {
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        Console.Write($"{Array[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }

            public void SumI(int n) // Нахождение суммы i-го столбца
            {
                int sum = 0;
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        if (j == n)
                        {
                            sum += Array[i, j];
                        }


                    }
                }
                Console.WriteLine("Сумма {0}-столбца -> {1}", n, sum);
            }

            public int Arrnull // свойство доступное только для чтения
            {
                get
                {
                    int quantity = 0;
                    for (int i = 0; i < Array.GetLength(0); i++)
                    {
                        for (int j = 0; j < Array.GetLength(1); j++)
                        {
                            if (Array[i, j] == 0)
                            {
                                quantity++;
                            }
                        }
                    }
                     return quantity;
                    
                }
            }

            public int Scalar // свойство доступное только для записи
            {
                set
                {
                    for (int i = 0; i < Array.GetLength(0); i++)
                    {
                        for (int j = 0; j < Array.GetLength(1); j++)
                        {
                            if (i == j)
                            {
                                Array[i, j] = value;
                            }

                        }
                    }
                }
            }

            public int this[int rows, int column]
            {
                get
                {
                    if (rows == 1 && column == 1)
                    {
                        return Array[rows, column];
                    }
                    else
                    {
                        return Array[rows, column];
                    }
                }
                set
                {
                    if (rows == 1 && column == 1)
                    {
                        Array[rows, column] = value;
                    }
                    else
                    {
                        if (rows == 0 && column == 1)
                        {
                            Array[rows, column] = value;
                        }
                    }
                }
            }
            
            public static cArray operator ++(cArray x) //перегрузка операции инкремента
            {
                
                // cArray temp = new cArray(x);
                int rows, column;
                for (rows = 0; rows < x.Array.GetLength(0); rows++)
                {
                    for (column = 0; column < x.Array.GetLength(1); column++)
                    {
                        x[rows, column] += 1;
                    }
                }
                return x;
            }
            

            public static cArray operator +(cArray x, cArray y) //вариант 2
            {
                if ((x.rows == y.rows)&&(x.column == y.column))
                {
                    cArray temp = new cArray(x.rows, x.column);
                    for (int i = 0; i < x.rows; i++)
                    {                       
                        for (int j = 0; j < x.column; j++)
                        {
                            temp[i, j] = x[i, j] + y[i, j];
                        }
                    }
                    return temp;
                }
                else
                {
                    Console.WriteLine("Несоответствие размерностей массивов ");
                    return null;
                }
            }

            // + оператор bool
            public static bool operator true(cArray a) //перегрузка константы true
            {
                if (a.rows == a.column)
                    return true;
                else return false;
            }
            public static bool operator false(cArray a) //перегрузка константы true
            {
                if (a.rows != a.column)
                    return false;
                else return true;
            }

            public static cArray operator --(cArray x) //перегрузка операции инкремента
            {
                int rows, column;
                for (rows = 0; rows < x.Array.GetLength(0); rows++)
                {
                    for (column = 0; column < x.Array.GetLength(1); column++)
                    {
                        x[rows, column] -= 1;
                    }
                }
                return x;
            }

            // Преобразования класса массив в двумерный массив (и наоборот).
            public static explicit operator int[,](cArray obj)
            {
                return obj.Array;
            }

            public static explicit operator cArray(int[,] array)
            {
                cArray obj = new cArray(array.Length, 0);
                array.CopyTo(obj.Array, 0);
                return obj;
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность друмерного массива ->");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            // int[,] Array
            cArray myArray = new cArray(n, m); //вызов конструктора(1)
           // Методы
            myArray.Input();
            myArray.Write();

            Console.WriteLine("Введите номер столбца -> ");
            n = int.Parse(Console.ReadLine());
            myArray.SumI(n);

            // Свойства
            Console.WriteLine("Количество нулей в массиве -> {0}", myArray.Arrnull);
            Console.WriteLine("Введите скаляра -> ");
            n = int.Parse(Console.ReadLine());
            myArray.Scalar = n;
            myArray.Write();
            Console.WriteLine();

            myArray[1, 1] = 5;
            myArray.Write();

            myArray--;
            Console.WriteLine("Оператор -- -> ");
            myArray.Write();

            Console.WriteLine("Введите размерность друмерного массива 2 ->");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            cArray myArray2 = new cArray(n, m);
                                               
            myArray2.Input();
            myArray2.Write();
            myArray.Write();
            myArray = myArray + myArray2;
            Console.WriteLine("Массив ->");
            myArray.Write();
            if (myArray) Console.WriteLine("Массив квадратный");
            else Console.WriteLine("Массив не квадратный");


            Console.ReadKey();
        }
    }
}
