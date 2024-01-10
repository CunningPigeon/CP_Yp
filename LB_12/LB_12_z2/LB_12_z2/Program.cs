using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_12_z2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int notint = rnd.Next(32768, 2147483647); // Присваиваем int значение большее чем 
            byte bt; // Переменная типа byte
            try // Внешний обработчик
            {
                try // Внутренний обработчик
                {
                    checked // защита от переполнения
                    {
                        bt = (byte)notint; //  Присваивание byte значение переменной notshort
                    }
                    Console.WriteLine(bt.ToString()); // Пытаемся вывести в консоль полученное значение
                }
                catch // Начало внутреннего обработчика
                {
                    Console.WriteLine("Сработал внутренний обработчик.");
                }
            }
            catch // Начало внешнего обработчика
            {
                Console.WriteLine("Сработал внешний обработчик."); 
            }
            finally
            {
                Console.WriteLine("Завершение программы.");
            }

            Console.ReadKey();
        }
    }
}
