using System;

class Problem9 {
    static void Main(string[] args){
        
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the third number: ");
        double num3 = double.Parse(Console.ReadLine());
        
     
        double average = (num1 + num2 + num3) / 3;
        
      
        Console.WriteLine($"The average is: {average}");
    }
}