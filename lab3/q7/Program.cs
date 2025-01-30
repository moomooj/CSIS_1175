using System;

class Q7
{
    static void Main(string[] args)
    {

        int input;
        
        while(true)
        {
            Console.Write("Enter a number (or type '-1' to quit): ");
            input = int.Parse(Console.ReadLine());

            if(input == -1)
            {
                break;
            }
            Console.WriteLine($"You entered :{input}");
        }
    }
}