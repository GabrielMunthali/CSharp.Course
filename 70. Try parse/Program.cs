﻿Console.WriteLine("Give me a number");
string inputString = Console.ReadLine();
int num1 = 0;

bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
    Console.WriteLine("well done, you have entered a number");
}
else
{
    Console.WriteLine("Haha you troll, you shouldve entered a number");
}

num1++;

Console.WriteLine("User entered number +1 " + num1);
Console.ReadLine();