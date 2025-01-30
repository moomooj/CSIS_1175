using System;

class Problem6 {
    static void Main(string[] args){
        Console.Write("Enter the age : ");
        int number =  int.Parse(Console.ReadLine());

        if(number  >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
        else
            {
                Console.WriteLine("You are not an adult.");
            }
    }
}
