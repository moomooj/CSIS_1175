using System;

class LogicalOperatorsExample {
    static void Main(string[] args){
    
        int num1 = 10;
        int num2 = 5;
        int num3 = 0;

        if((num1 > 5) && (num2 > 3)){
            Console.WriteLine($"Condition1 (num1 > 5 && num2 > 3):  True");
        }
        if((num1 < 5) || (num2 > 3)){
            Console.WriteLine($"Condition2 (num1 < 5 || num2 > 3): true");
        }
        bool condition3 = !(num3 == 0);

        if(!(num3 == 0)){
            Console.WriteLine($"Condition3 (!(num3 == 0)): False");
        }
        if(((num1 > 5) && (num2 > 3)) || (num3 == 0)){
            Console.WriteLine($"Condition4 (((num1 > 5) && (num2 > 3)) || (num3 == 0)): true");
        }

    }
}