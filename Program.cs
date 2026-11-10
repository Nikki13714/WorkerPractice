using System;
using System.Collections.Generic;

namespace WorkerPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var workers = new List<Worker>(); // стандартный список для хранения объектов
            int currentYear = DateTime.Now.Year;

            Console.Write("Введите количество работников: ");
            int n = int.Parse(Console.ReadLine());

            // Ввод данных класса типа WORKER с клавиатуры
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Работник №{i + 1} ---");
                Console.Write("Фамилия и инициалы: ");
                string fio = Console.ReadLine();
                Console.Write("Должность: ");
                string position = Console.ReadLine();
                Console.Write("Зарплата: ");
                double salary = double.Parse(Console.ReadLine());
                Console.Write("Год поступления на работу: ");
                int year = int.Parse(Console.ReadLine());

                workers.Add(new Worker(fio, position, salary, year));
            }

            Console.Write("\nВведите минимальный стаж (в годах): ");
            int threshold = int.Parse(Console.ReadLine());

            // Вывод фамилий работников, чей стаж превышает заданное значение
            bool found = false;
            Console.WriteLine($"\nРаботники со стажем более {threshold} лет:");
            foreach (var w in workers)
            {
                if (w.GetExperience(currentYear) > threshold)
                {
                    w.Display();
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Работников с таким стажем нет.");

            Console.ReadKey();
        }
    }
}
