using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_13_14_3
{
    // Создаем делегат
    delegate void MyEventHandler(string newName);

    // Создаем класс события
    class MyEvent
    {
        // Создаем событие
        public static event MyEventHandler NameChanged;

        // Создаем метод, который вызывает событие
        public static void OnNameChanged(string newName)
        {
            // Проверяем, есть ли подписчики на событие
            if (NameChanged != null)
            {
                // Вызываем событие и передаем новое название
                NameChanged(newName);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Меняем вид консоли
            Console.Title = "Название автомобиля";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            string name = "Ford";
            Console.WriteLine($"Название автомобиля - {name} ");
            Console.Write("Введите новое название автомобиля - ");
            string name1 = Console.ReadLine();

            // Подписываемся на событие
            MyEvent.NameChanged += NameChangedHandler;


            Console.WriteLine("Желаете принять изменения? (Y/N): ");
            string decision = Console.ReadLine();

            if (decision.ToLower() == "n")
            {
                Console.WriteLine($"Название не изменилось! Название автомобиля - {name}");
            }
            else
            {
                // Генерируем событие
                MyEvent.OnNameChanged(name1);
            }

            Console.ReadKey();
        }

        // Обработчик события изменения названия
        static void NameChangedHandler(string newName)
        {
            Console.WriteLine($"Название изменилось!\nНовое название автомобиля - {newName}");
        }
    }
}
