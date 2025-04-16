Random random = new Random();
int randomNumber = random.Next(1, 11);

Console.WriteLine("Guess a number");


string inputString = Console.ReadLine();
int num1 = 0;

bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
    if (randomNumber == num1)
    {
        Console.WriteLine("You guessed right!");
    }
    else
    {
        Console.WriteLine("You guessed wrong!, try again");
    }
}
else
{
    Console.WriteLine("Haha you troll, you should've entered a number");
}

num1++;

Console.WriteLine("User entered number +1 " + num1);
Console.ReadLine();