// Lab 2:reference parameter in C# is a way to pass an argument to a method by reference rather than by value. When you pass a parameter by reference, any changes made to the parameter inside the method will affect the original variable outside the method. This is done using the ref keyword in both the method signature and the method call.
//title for reference and out parameter for lab2 is 
/*using System;
namespace practice
{
    class Program
    {
        public static void Display(ref int x, ref int y)
        {
            x = 10;
            y = 20;
        }  static void Main(string[] args)
        {
            int a = 55, b = 150;

            Console.WriteLine("Lab2Q1: Reference Parameter\n");
            Console.WriteLine($"num1={a}, num2={b}");

            Display(ref a, ref b);

            Console.WriteLine($"num1={a}, num2={b}");
            Console.WriteLine("\nAnil Pal 5");
        }
    }
}
*/

//out parameter in C# is similar to a reference parameter, but it is used to indicate that a method will assign a value to the parameter before the method returns. The out keyword is used in both the method signature and the method call. Unlike ref parameters, out parameters do not require the variable to be initialized before being passed to the method.

/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        public static void Multiply(out int a,out int b,out int c)
        {
            a = 100;
            b = 5;
            c = a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lab2Q2: out parameter in C#\n");
            int x,y,z;
            Multiply(out x, out y, out z);
            Console.WriteLine($"num1={x}\n\nnum2={y}\n\nThe multiply of {x} and {y} is ={z}");
            Console.WriteLine("\nAnil Pal 5");
        }
    }
}
*/
//Lab1:in c#,sum of two numbers
//title for this sum of two numbers and multiplication table
using System;
namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab1Q1: Sum of two numbers\n");
            int num1, num2, sum;
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
            Console.WriteLine("\nAnil Pal 5");
        }
    }
}
*/

//Lab1:display the multiplication table from 1 to 10 take input from user
/*using System;
namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab1Q2: Display the multiplication table from 1 to 10\n");
            int num;
            Console.WriteLine("Enter a number to display its multiplication table:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiplication table of {num}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
            Console.WriteLine("\nAnil Pal 5");
        }
    }
}*/