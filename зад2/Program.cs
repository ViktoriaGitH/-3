using System;

namespace зад2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human student = new Student("Ивано", "Иванов", 10);
            Human worker = new Worker("Лили", "Иванова", 15.5m, 40);

            student.PrintInfo();
            worker.PrintInfo();

           
            if (worker is Worker)
            {
                Worker workerObj = (Worker)worker;
                Console.WriteLine($"Цялостн ЗАПЛАТА: {workerObj.CalculateHourlyWage()}");
            }
        }
    }


    class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Име: {FirstName} {LastName}");
        }
    }

    class Student : Human
    {
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            Grade = grade;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Оценка: {Grade}");
        }
    }

    class Worker : Human
    {
        public decimal HourlyRate { get; set; }
        public int WorkedHours { get; set; }

        public Worker(string firstName, string lastName, decimal hourlyRate, int workedHours) : base(firstName, lastName)
        {
            HourlyRate = hourlyRate;
            WorkedHours = workedHours;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Надница: {HourlyRate}, Работни часове: {WorkedHours}");
        }

        public virtual decimal CalculateHourlyWage()
        {
            return HourlyRate * WorkedHours;
        }
    }
}