using System;

class Problem8 {
    static void Main(string[] args){
    
        Console.Write("Enter your grade (A, B, C, D, F): ");
        string grade = Console.ReadLine().ToUpper(); 

    
        if (grade == "A") {
            Console.WriteLine("NICEEEEEEEE!");
        }
        else if (grade == "B") {
            Console.WriteLine("Good job!");
        }
        else if (grade == "C") {
            Console.WriteLine("You passed.");
        }
        else if (grade == "D") {
            Console.WriteLine("You need improvement.");
        }
        else if (grade == "F") {
            Console.WriteLine("SO BAD.");
        }
    }
}
