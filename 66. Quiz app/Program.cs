﻿string question1 = "What is the capital of Malawi";
string answer1 = "Lilongwe";

string question2 = "What is 2 + 2";
string answer2 = "4";

string question3 = "What color do you get by mixing yellow and green colors";
string answer3 = "Green";

int score = 0;




Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1 == answer1)
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer1);
}




Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2 == answer2)
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer2);
}




Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3 == answer3)
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer3);
}

Console.WriteLine($"Quiz completed: {score}/3");




if (score == 3)
{
    Console.WriteLine("Excellent ! You got all the answers right");
} else if (score > 0)
{
    Console.WriteLine("Good Job, but keep learning"); 
}
else
{
    Console.WriteLine("Try Again");
}




Console.ReadKey();