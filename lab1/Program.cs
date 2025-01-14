using System;


class Program
{
    static void Main(string[] args)
    {
       Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
    
        int futureAge = age +5;

        Console.WriteLine($"In 5 yars, you will be {futureAge} years old.");
    }
}


/*
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        float divistion = (float)num1 / num2;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {divistion}");
    }
}


*/

