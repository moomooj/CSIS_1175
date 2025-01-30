using System;

class Problem5 {
    static void Main(string[] args){
        Console.Write("Enter the number : ");
        int number =  int.Parse(Console.ReadLine());

        if(number  > 0)
            {
                Console.WriteLine("This number is positive.");
            }
        else if(number < 0)
            {
                Console.WriteLine("This number is negative.");
            }
        else
            {
                Console.WriteLine("This number is zero.");
            }
    }
}
