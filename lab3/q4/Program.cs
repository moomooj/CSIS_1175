using System;

class Q4
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}