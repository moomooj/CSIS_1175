using System;

class Q9
{
    static void Main(string[] args)
    {
        int choice;
        do{
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Ramen");
            Console.WriteLine("2. Rice");
            Console.WriteLine("3. Bread");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");

            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
            case 1:
                Console.WriteLine("You selected Ramen.");
                break;  
            case 2:
                Console.WriteLine("You selected Rice.");
                break;      
            case 3:
                Console.WriteLine("You selected Bread.");
                break;
            case 4:     
                Console.WriteLine("Exit the Menu.");
                break;
            default:   
                Console.WriteLine("Invalid option.");
                break;
            }
        }
        while(choice != 4);
    }
}