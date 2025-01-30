using System;

class Problem2 {
    static void Main(string[] args){
        Console.Write("Enter your name : ");
        string name =  Console.ReadLine();

        Console.Write("Enter your age : ");
        int age =  int.Parse(Console.ReadLine());

        Console.Write("Enter your GPA : ");
        float gpa =  float.Parse(Console.ReadLine());
        Console.WriteLine($"name : {name}, age : {age}, GPA : {gpa}");
    }
}
