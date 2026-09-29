using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string College { get; set; }
}

class Program
{
    static void Main()
    {
        // Create five student records
        List<Student> students = new List<Student>
        {
            new Student
            {
                FirstName = "Anil",
                LastName = "Pal",
                Address = "Lalitpur",
                College = "KCT"
            },

            new Student
            {
                FirstName = "Bikash",
                LastName = "Shrestha",
                Address = "Kathmandu",
                College = "KCT"
            },

            new Student
            {
                FirstName = "Ramesh",
                LastName = "Thapa",
                Address = "Lalitpur",
                College = "KCT"
            },

            new Student
            {
                FirstName = "Sita",
                LastName = "Gurung",
                Address = "Bhaktapur",
                College = "KCT"
            },

            new Student
            {
                FirstName = "Nisha",
                LastName = "Karki",
                Address = "Lalitpur",
                College = "KCT"
            }
        };

        // LINQ query
        var result = students
            .Where(s => s.Address == "Lalitpur"
                     && s.College == "KCT")
            .OrderByDescending(s => s.FirstName);

        Console.WriteLine(
            "Students from Lalitpur studying at KCT:"
        );

        Console.WriteLine();

        // Display result
        foreach (var student in result)
        {
            Console.WriteLine(
                student.FirstName + " " +
                student.LastName + " - " +
                student.Address + " - " +
                student.College
            );
        }
    }
}
