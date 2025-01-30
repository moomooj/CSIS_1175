using System;

class Problem3 {
    static void Main(string[] args){
        Console.Write("Enter your first number : ");
        int num1 =  int.Parse(Console.ReadLine());

        Console.Write("Enter your Second number : ");
        int num2 =  int.Parse(Console.ReadLine());

        Console.WriteLine($"Additon : {num1 + num2}");
        Console.WriteLine($"Subtraction : {num1 - num2}");
        Console.WriteLine($"Multiplication : {num1 * num2}");
        Console.WriteLine($"Division : {num1 / num2}");
        Console.WriteLine($"Modulus : {num1 % num2}");
    }
}
