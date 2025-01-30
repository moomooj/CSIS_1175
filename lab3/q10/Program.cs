using System;

class Q10
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int userGuess;

        Console.WriteLine("I have selected a random number between 1 and 100.");
        Console.WriteLine("Can you guess what it is?");
        
        do
        {
            Console.Write("Enter your guess:");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < randomNumber)
            {
                Console.WriteLine("Too low. Try again.");
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Too high. Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the number.");
            }
        }
        while (userGuess != randomNumber);
    }
}