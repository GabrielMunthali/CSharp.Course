string myString = "Hie \r\nHie";



for (int counter = 10; counter >= 0; counter--)
{
    Console.WriteLine("Counter is " + counter);
    Console.WriteLine(myString);
    Thread.Sleep(1000);
}

Console.ReadKey();