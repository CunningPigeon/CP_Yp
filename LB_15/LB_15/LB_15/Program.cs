using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication2

{
    class Program

    {
        static void Main(string[] args)
        {
            string[] strmas;// Объявление массива строк

            if (File.Exists(@"D:\project\LB_15\LB_15\числа.txt")) // Проверка существования файла

            { // Считывание данных в массив строк

                strmas = File.ReadAllLines(@"D:\project\LB_15\LB_15\числа.txt");
                int[] strmas1 = new int[strmas.Length];
                for (int i = 0; i < strmas.Length; i++)
                {
                    strmas1[i] = int.Parse(strmas[i]);
                }
                //сортировка массива
                Array.Sort(strmas1);
                for (int i = 0; i < strmas.Length; i++)
                {
                    strmas[i] = strmas1[i].ToString();
                }

                //запись массива в файл
                File.WriteAllLines(@"D:\project\LB_15\LB_15\сортировка.txt", strmas);

            }

        }

    }

}
