using System;

enum Day
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
struct Student
{
    public int Id;
    public string Name;
    public double Marks;

    public Student(int id, string name, double marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }

    public void Display()
    {
        Console.WriteLine("Student ID: " + Id);
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Marks: " + Marks);
    }
}

class Program
{
    static void Main()
    {
        Day today = Day.Wednesday;

        Console.WriteLine("Today is: " + today);

        Console.WriteLine();

        Student student = new Student(
            1,
            "Anil",
            85.5
        );

        student.Display();
    }
}