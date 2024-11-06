using System;

namespace MyApp;

class Program
{
    static void Main(string[] args)
    {
        bool isRainy = false;
        bool hasUmbrella = false;

        if ( !isRainy || hasUmbrella )
        {
            Console.WriteLine("I am not getting wet");
        }

        Console.WriteLine("Ay ok !");
    }
}
