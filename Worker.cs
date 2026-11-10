using System;

namespace WorkerPractice
{
    /// <summary>
    /// Класс WORKER — работник организации (Университет "Синергия").
    /// </summary>
    public class Worker
    {
        private string fio;        // фамилия и инициалы работника
        private string position;   // название занимаемой должности
        private double salary;     // заработная плата
        private int hireYear;      // год поступления на работу

        // Конструктор по умолчанию
        public Worker()
        {
            fio = "Не указано";
            position = "Не указано";
            salary = 0;
            hireYear = DateTime.Now.Year;
        }

        // Конструктор с параметрами (полный)
        public Worker(string fio, string position, double salary, int hireYear)
        {
            this.fio = fio;
            this.position = position;
            this.salary = salary;
            this.hireYear = hireYear;
        }

        // Конструктор с частичным набором параметров
        public Worker(string fio, string position)
        {
            this.fio = fio;
            this.position = position;
            salary = 0;
            hireYear = DateTime.Now.Year;
        }

        // Деструктор
        ~Worker() { }

        // Методы изменения полей класса
        public void SetFio(string fio)      { this.fio = fio; }
        public void SetPosition(string pos) { this.position = pos; }
        public void SetSalary(double s)     { this.salary = s; }
        public void SetHireYear(int year)   { this.hireYear = year; }

        // Методы отображения полей класса
        public void Display()
        {
            Console.WriteLine($"ФИО: {fio}, должность: {position}, " +
                $"зарплата: {salary:N2} руб., год поступления: {hireYear}");
        }

        // Методы доступа (геттеры)
        public string GetFio()      { return fio; }
        public string GetPosition() { return position; }
        public double GetSalary()   { return salary; }
        public int GetHireYear()    { return hireYear; }

        // Метод подсчета стажа работы в организации (в полных годах)
        public int GetExperience(int currentYear)
        {
            return currentYear - hireYear;
        }
    }
}
