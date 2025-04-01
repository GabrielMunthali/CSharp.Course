
int num1 = 0;
int num2 = 0;

bool isEqual = num1 == num2;

bool isNotEqual = num1 != num2;

Console.WriteLine("Please enter a whole number");

if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal");

    Console.WriteLine("Please enter your age");
    int age = int.Parse(Console.ReadLine());
    if (age >= 18)
    {
        Console.WriteLine("Please enter your address, " + "so that we can send you the price!");
        
        string address = Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Sorry you cant your price due to your age");
}