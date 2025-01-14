using System;

class Program4
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first Number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the scond number : ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Sum : {num1 + num2}");
        Console.WriteLine($"Differance : {num1 - num2}");
        Console.WriteLine($"Product : {num1 * num2}");
        Console.WriteLine($"Quotient : {(float)num1 / num2}");

    }
    

}