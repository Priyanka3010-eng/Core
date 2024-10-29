using System;

namespace DotNetCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from .NET Core!");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your number squared is: {number * number}");
        }
    }
}
