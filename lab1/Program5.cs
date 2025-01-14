using System;

class Program5
{
    static void Main(string[] args)
    {
       Console.WriteLine("Enter your age: ");
       int age = int.Parse(Console.ReadLine());
       int futureAge = age + 5;

        Console.WriteLine($"In 5 years, you will be {futureAge} years old.");
    }

}
