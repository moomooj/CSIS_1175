using System;

class Q5
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if(isPrime && number > 1)
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    }
}