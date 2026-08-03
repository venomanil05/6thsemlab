//1. Default Constructor
/*using System;
class Student
{
    public string Name;
    public int Age;
    public Student()
    {
        Name = "Ram";
        Age = 20;
    }
    public void Display()
    {
        Console.WriteLine("Lab3Q1: Default Constructor");
        Console.WriteLine($"Name: {Name}, Age: {Age}");
        Console.WriteLine("Anil Pal 5");
    }
    static void Main()
    {
        Student s1 = new Student();
        s1.Display();
    }
}
*/

//parameterized constructor
/*using System;
class Student
{
    public string Name;
    public int Age;
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Display()
    {
        Console.WriteLine("Lab3Q2: Parameterized Constructor\n");
        Console.WriteLine($"Name: {Name}, Age: {Age}");
        Console.WriteLine("\nAnil Pal 5");
    }
    static void Main()
    {
        Student s1 = new Student("Alice", 20);
        s1.Display();
    }
} */

//copy constructor
/*using System;

namespace CopyConstructorDemo
{
    class Animal
    {
        public string Name;
        public string Shelter;

        // Parameterized Constructor
        public Animal(string name, string shelter)
        {
            Name = name;
            Shelter = shelter;
        }

        // Copy Constructor
        public Animal(Animal a)
        {
            Name = a.Name;
            Shelter = a.Shelter;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Shelter: {Shelter}");
        }
    }

    class Dog : Animal
    {
        // Copy Constructor
        public Dog(Animal a) : base(a)
        {
        }
    }

    class Tiger : Animal
    {
        // Copy Constructor
        public Tiger(Animal a) : base(a)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Original Animal object
            Animal a1 = new Animal("Tommy", "Animal Shelter");

            Dog d1 = new Dog(a1);
            Tiger t1 = new Tiger(a1);

            Console.WriteLine("Animal Details:");
            a1.Display();

            Console.WriteLine("\nDog Details (Copied):");
            d1.Display();

            Console.WriteLine("\nTiger Details (Copied):");
            t1.Display();
        }
    }
}
*/

//static constructor
/*using System;

class Student
{
    static string College;
    static Student()
    {
        College = "Himalaya College of engineering";
    }
    public Student()
    {
        Console.WriteLine("Object Created");
    }
    public void Display()
    {
        Console.WriteLine("College: " + College);
    }
   static void Main()
    {
        Console.WriteLine("Lab3Q4:static constructor");
        Student s1 = new Student();
        s1.Display();

        Student s2 = new Student();
        s2.Display();
        Console.WriteLine("\nAnil Pal 5");
    }
}
*/

//Private constructor
using System;
namespace Lab3Q5
{
    class Student
    {
        private static Student instance;
        public string Name;
        public int Age;
        private Student()
        {
            Name = "Venom";
            Age = 20;
        }
        public static Student GetInstance()
        {
            if (instance == null)
            {
                instance = new Student();
            }
            return instance;
        }
        public void Display()
        {
            Console.WriteLine("Lab3Q5: Private Constructor\n");
            Console.WriteLine($"Name: {Name}, Age: {Age}");
            Console.WriteLine("\nAnil Pal 5");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = Student.GetInstance();
            s1.Display();
        }
    }
}


