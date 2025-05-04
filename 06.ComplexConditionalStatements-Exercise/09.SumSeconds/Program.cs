using System;

class Program
{
    static void Main()
    {
        int resultOne = int.Parse(Console.ReadLine());
        int resultTwo = int.Parse(Console.ReadLine());
        int resultThree = int.Parse(Console.ReadLine());

         
        int totalTimeInSeconds = resultOne + resultTwo + resultThree;

        
        int minutes = totalTimeInSeconds / 60;
        int seconds = totalTimeInSeconds % 60;

         
        Console.WriteLine($"{minutes}:{seconds:D2}");
    }
}
