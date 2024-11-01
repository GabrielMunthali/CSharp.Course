using System;

namespace MyApp;

class Program
{
    static void Main(string[] args)
    {
        int num = 10;
        double price =  10.99;
        string name =  "John";

        //Interpolation
        Console.WriteLine($"The number is {num}");

        //Concatenation
        Console.WriteLine("The number is " + num);

        //String formatting
        Console.WriteLine("The number is {0}, and the price is {1}, and the name is {2}",  num, price, name);


        Console.ReadKey();
    }
}
