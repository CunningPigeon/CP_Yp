using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LB_8
{
    internal class Program
    {
        /*/struct Book
        {
            public string surname, name, patron, clas, grade;
            
            public void Info()
            {
                Console.WriteLine("Вывод данных структуры");
                Console.WriteLine("Школьник {0} {1} {2}; \n Год рождения {3}; \n Оценки вступительных экзаменов {4}; \n Средний балл аттестата {5};", surname, name, patron, clas, grade);
            }
            
        }
        static void DEl()
        {
            Console.WriteLine("Абиьуриент {0} {1} {2}; \n Год рождения {3}; \n Оценки вступительных экзаменов {4}; \n Средний балл аттестата {5};");
        }
        static void Input(int i)
        {
            

            int n = 0;
            while (n < i)
            {
                Console.WriteLine("Ввод данных в структуру");

                Console.Write("Введите фамилию {0} школьника -> ", n);
                books[n].surname = Console.ReadLine();

                Console.Write("Введите имя {0} школьника -> ", n);
                books[n].name = Console.ReadLine();

                Console.Write("Введите отчество {0} школьника -> ", n);
                books[n].patron = Console.ReadLine();

                Console.Write("Введите класс {0} школьника  -> ", n);
                books[n].clas = Console.ReadLine();

                Console.Write("Введите оценки по предметам (математика, физика, русский язык, литература)  {0} школьника-> ", n);
                books[n].grade = Console.ReadLine();
            }

        }

        static void Main(string[] args)
        {
            Book[] books = new Book[1];

            //Resize
            int n = 0, k = 1;
            Console.Write("Структура: \n\t-1(Просмотр данных структуры);\n\t-2(Ввод данных в структуру);\n\t-3(Удаление); ");
            n = int.Parse(Console.ReadLine());
            while (k == 1){
                if (n == 1)
                {
                    //Выведем информацию о книге book на экран

                    foreach (Book b in books)
                    {
                        b.Info();
                    }



                    Console.Write("Продолжить ? (1-да/0-нет) ->");
                    k = int.Parse(Console.ReadLine());
                } else if (n == 2)
                {
                    Console.Write("Кол-во школьников для ввода ->");
                    int i = int.Parse(Console.ReadLine());

                    Input(i);

                    Console.Write("Продолжить ? (1-да/0-нет) ->");
                    k = int.Parse(Console.ReadLine());

                } else if (n == 3)
                {
                    Console.Write("Продолжить ? (1-да/0-нет) ->");
                    k = int.Parse(Console.ReadLine());
                } else
                {
                    Console.Write("Не верный ввод ф-ции структуры");
                    Console.Write("Продолжить ? (1-да/0-нет) ->");
                    k = int.Parse(Console.ReadLine());
                }
            }

            Console.ReadLine();
        }
    }
        */

        struct School
        {
            public string FullName; // Фамилия, имя, отчество
            public string clas; // Домашний адрес clas
            public int GradeM; // Оценкa gradeM
            public int GradeR; // Оценкa gradeR
            public string Phone; // Номер телефона
        }
        static void Main()
        {
            Console.Write("Кол-во элементов: ");
            int arraySize = int.Parse(Console.ReadLine()); // Размер массива школьников
            
            

            // Инициализация массива структур
            School[] Array = new School[arraySize];

            

            // Заполнение массива
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Введите данные {i + 1} школьника ->");

                Console.Write("ФИО -> ");
                Array[i].FullName = Console.ReadLine();

                Console.Write("Класс: ");
                Array[i].clas = Console.ReadLine();

                Console.Write("Оценки по математике -> ");
                Array[i].GradeM = int.Parse(Console.ReadLine());

                Console.Write("Оценки по русскому -> ");
                Array[i].GradeR = int.Parse(Console.ReadLine());

                Console.Write("Номер телефона -> ");
                Array[i].Phone = Console.ReadLine();

                Console.WriteLine();
            }

            // Вывод заполненного массива
            Console.WriteLine("Заполненный массив школьников ->");
            Print(Array);

            // Удаление элемента с заданным
            Delete(ref Array, arraySize);

            // Вывод массива после удаления
            Console.WriteLine($"Массив после удаления школьника ->");
            Print(Array);

            // Добавление K элементов в начало массива
            Console.Write("Кол-во элементов для добавления в массив структур ->");
            int k = int.Parse(Console.ReadLine());
            Add(ref Array, k);

            // Вывод измененного массива
            Console.WriteLine($"Массив после добавления {k} школьника ->");
            Print(Array);

            Console.ReadKey();
        }

        // Метод для вывода массива пациентов на экран
        static void Print(School[] array)
        {
            foreach (var school in array)
            {
                Console.WriteLine($"ФИО -> {school.FullName}, Класс -> {school.clas}, " +
                                  $"Оценки по математике -> {school.GradeM}, Оценки по русскому -> {school.GradeR}, Телефон -> {school.Phone}");
            }
            Console.WriteLine();
        }

        // Метод для удаления школьника из массива
        static void Delete(ref School[] array, int n)
        {

            // Удаление элементов из массива
            int newLength = 0;
            School[] newArray = new School[array.Length];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i].GradeM > 2) && (array[i].GradeR > 2))
                {
                    newLength++;
                    newArray[j] = array[i];
                    j++;
                }
            }
            Array.Resize(ref newArray, newLength);
            array = newArray;


        }

        // Метод для добавления возникшего школьника в конец массива
        static void Add(ref School[] array, int k)
        {
            for (int i = 0; i < k; i++)
            {
                School ArrayS = new School();

                Console.WriteLine($"Введите данные школьника {i + 1} ->");

                Console.Write("ФИО -> ");
                ArrayS.FullName = Console.ReadLine();

                Console.Write("Класс -> ");
                ArrayS.clas = Console.ReadLine();

                Console.Write("Оценки по математике -> ");
                ArrayS.GradeM = int.Parse(Console.ReadLine());

                Console.Write("Оценки по русскому -> ");
                ArrayS.GradeR = int.Parse(Console.ReadLine());

                Console.Write("Номер телефона -> ");
                ArrayS.Phone = Console.ReadLine();

                // Увеличение размера массива
                Array.Resize(ref array, array.Length + 1);

                // Добавление нового пациента в конец массива
                array[array.Length - 1] = ArrayS;

                Console.WriteLine();
            }
        }
    }


}

   
