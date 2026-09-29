using System;
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
    public void Eat()
    {
        Console.WriteLine("Animal eats food.");
    }
}
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks.");
    }
    public new void Eat()
    {
        Console.WriteLine("Dog eats dog food.");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();

        Console.WriteLine("Method Overriding:");
        dog.Sound();

        Console.WriteLine();

        Console.WriteLine("Method Hiding:");
        dog.Eat();

        Console.WriteLine();

        Animal animal = dog;

        Console.WriteLine("Using Parent Reference:");
        animal.Sound();
        animal.Eat();
    }
}
