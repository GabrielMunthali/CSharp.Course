using System;

namespace MyApp;

class Program
{
    static void Main(string[] args)
    {
        bool isRainy = true;
        bool hasUmbrella = false;

        if (isRainy && !hasUmbrella)
        {
            Console.WriteLine("I am getting wet");
        }

        Console.WriteLine("Ay ok !");
    }
}
