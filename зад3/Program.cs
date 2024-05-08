using System;

namespace зад3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
       {
            new Dog("Макс", 5, "Мъжко"),
            new Frog("Жабчо", 2, "Мъжко"),
            new Cat("Пуха", 3, "Женска"),
            new Kitten("Кити", 1),
            new Tomcat("Том", 4)
       };

            foreach (var animal in animals)
            {
                Console.WriteLine($"Име: {animal.Name}, Години: {animal.Age}");
                Console.Write("Звук: ");
                animal.MakeSound();
                Console.WriteLine();
            }
        }
    }


    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Животното издава звук");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Бау");
        }
    }

    class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Квак");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Мяу");
        }
    }

    class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, "Женско")
        {
        }
    }

    class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, "Мъжко")
        {
        }
    }
}