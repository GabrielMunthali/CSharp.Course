using System;

namespace Else;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 6;

        bool isGreater = num1 > num2; // Relational operator

        int age = 17;

        if (age >= 18)
        {
            Console.WriteLine("Go party");
        } else 
            {
                Console.WriteLine("No");
            }

    }
}
