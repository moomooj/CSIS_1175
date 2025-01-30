using System;

class Q8
{
    static void Main(string[] args)
    {
        
        while(true)
        {
            Console.Write("Enter a number to calculate its factorial: ");
            int number = int.Parse(Console.ReadLine());

            if(number < 0)
            {
                Console.WriteLine("negative numbers.");
            return;
            }
                
            int factorial = 1;
            int i = 1;

            while(i <= number)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"The factorial of {number} is {factorial}.");
        }
    }
}