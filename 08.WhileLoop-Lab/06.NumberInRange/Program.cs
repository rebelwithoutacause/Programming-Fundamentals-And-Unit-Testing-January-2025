﻿int number = int.Parse(Console.ReadLine());

while (number < 1 || number > 100)
{
    number = int.Parse(Console.ReadLine());
}

Console.WriteLine(number);