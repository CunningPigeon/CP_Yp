using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_2_z3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите баллы -> ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 90 && x <= 100) // Проверка баллов на диапазон 90-100
            {
                Console.WriteLine("Отлично");
            }
            else
                if (x >= 70 && x <= 89)
                {
                Console.WriteLine("Хорошо");
                }
            else
            {
                if (x >= 50 && x <= 69)
                {
                    Console.WriteLine("Удовлетворительно");
                }
                else
                {
                        Console.WriteLine("Неудовлетворительно");
                }
            }
            Console.ReadKey();
        }
        }
    }
