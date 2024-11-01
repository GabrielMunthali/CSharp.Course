using System;

namespace MyApp
{
    class Program
    {   


        static void Main(string[] args)
        {

            //Operators and Order of evaluation
            int num1 = 14;
            Console.WriteLine("Please enter a whole number !");
            int num2 = int.Parse (Console.ReadLine());

            //Concatination
            Console.WriteLine("Age is " + num1);

            
            Console.WriteLine("Addition num1 + num2 = " + (num1 + num2));
            //Order of evaluation
            Console.WriteLine("Subtraction num1 - num2 = "  + (num1 - num2));

            Console.WriteLine("Division num1 / num2 = " + num1 / num2);

        }
    }
}