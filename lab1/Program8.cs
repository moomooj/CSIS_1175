using System;

class Program8
{
static void Main ( string [] args ){

    Console . Write ( " Enter the length : " ) ;
    int length =  int.Parse(Console.ReadLine()); // Fill in to take length

    Console . Write ( " Enter the width : " ) ;
    int width = int.Parse(Console.ReadLine());

    int area = length * width;
    Console . WriteLine ( $" The area of the rectangle is {area}. " ) ;
}
}
