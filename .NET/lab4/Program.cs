using System;

//method hiding and overriding in C#
/*namespace MethodHidingAndOverriding
{
    class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Display method in BaseClass");
        }
    }
    class DerivedClass : BaseClass
    {
        public new void Display()
        {
            Console.WriteLine("Display method in DerivedClass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            baseObj.Display(); 
            DerivedClass derivedObj = new DerivedClass();
            derivedObj.Display();
            BaseClass baseRefDerived = new DerivedClass();
            baseRefDerived.Display(); 
            Console.ReadLine();
        }
    }
}
*/
//concept of polymorphism in C#
/*using System;
using System.Collections.Generic;

namespace PolymorphismExample
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog(),
                new Cat()
            };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }

            Console.ReadLine();
        }
    }
}
*/
//operator overloading in C#
/*using system;
namespace OperatorOverloadingExample
{
    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);
        public static Point operator -(Point a, Point b) => new Point(a.X - b.X, a.Y - b.Y);
        public static Point operator *(Point p, int scalar) => new Point(p.X * scalar, p.Y * scalar);
        public static Point operator *(int scalar, Point p) => p * scalar;

        public override string ToString() => $"({X}, {Y})";
    }

    class Program
    {
        static void Main()
        {
            var p1 = new Point(2, 3);
            var p2 = new Point(4, 1);

            var sum = p1 + p2;
            var diff = p2 - p1;
            var scaled = p1 * 3;

            Console.WriteLine($"p1 = {p1}");
            Console.WriteLine($"p2 = {p2}");
            Console.WriteLine($"p1 + p2 = {sum}");
            Console.WriteLine($"p2 - p1 = {diff}");
            Console.WriteLine($"p1 * 3 = {scaled}");

            Console.ReadLine();
        }
    }
}
*/

//abstract class concept in C#

/*using System;
abstract class Teacher
{
    public static void Show()
    {
        Console.WriteLine("Show Method");
    }

    public abstract void Display();
}
class Test : Teacher
{
    public override void Display()
    {
        Console.WriteLine("Test Class");
    }
    static void Main(string[] args)
    {
        Teacher.Show();

        Test t = new Test();
        t.Display();

        Console.ReadLine();
    }
}
*/

//interface concept in C#
using System;
interface Animal    
{
    void Sound();
    void Eat();
}
class Tiger : Animal
{
    public void Sound()
    {
        Console.WriteLine("Tiger Sound");
    }
    public void Eat()
    {
        Console.WriteLine("Tiger Eat");
    }
}
class Cat : Animal
{
    public void Sound()
    {
        Console.WriteLine("Cat Sound");
    }
    public void Eat()
    {
        Console.WriteLine("Cat Eat");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Cat obj1 = new Cat();
        obj1.Sound();
        obj1.Eat();

        Console.WriteLine();

        Tiger obj2 = new Tiger();
        obj2.Sound();
        obj2.Eat();

        Console.ReadLine();
    }
}


