namespace зад1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student { Name = "Иван", UniqueId = "S001", ClassNumber = 10 };
            Teacher teacher1 = new Teacher { Name = "госпожа Иванова", UniqueId = "T001" };
            Subject math = new Subject { Name = "Математика", Hours = 5, Exercises = 10 };

            


            teacher1.SubjectsTaught.Add(math);

            Classroom classroom1 = new Classroom();
            classroom1.Students.Add(student1);
            classroom1.Teachers.Add(teacher1);
        }
    }


    class Human
    {
        public string Name { get; set; }
        public string UniqueId { get; set; }
    }

    class Student : Human
    {
        public int ClassNumber { get; set; }
    }

    class Subject
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public int Exercises { get; set; }
    }

    class Teacher : Human
    {
        public List<Subject> SubjectsTaught { get; set; }

        public Teacher()
        {
            SubjectsTaught = new List<Subject>();
        }
    }

    class Classroom
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public Classroom()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }
    }
}