using System;

class Problem7 {
    static void Main(string[] args){
        Console.Write("Enter the length of the rectangle: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());
       
        double area = length * width;

 
        Console.WriteLine("The area of the rectangle is: " + area);

    }
}
