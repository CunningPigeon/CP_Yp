using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_13_14_2
{
    internal class Program
    {
        //создаем делегат 
        delegate void MyEventHandler();
        //создаем класс события
        class MyEvent
        {
            //создание метода
            public static void IfChanged(string name, string name1)
            {
                if (name != name1)
                {
                    Console.WriteLine($"Название изменилось!\nНовое название автомобиля - {name1}");
                }
            }

        }
        static void Main(string[] args)
        {
            //меняем вид консоли
            Console.Title = "Название автомобиля";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            string name = "Ford";
            Console.WriteLine($"Название автомобиля - {name} ");
            Console.Write("Введите название авттомобиля - ");
            string name1 = Console.ReadLine();
            // Генерируем событие
            MyEvent.IfChanged(name, name1);

            Console.ReadKey();
        }
        

    }
}
