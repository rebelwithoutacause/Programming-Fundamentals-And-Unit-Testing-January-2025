﻿int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int result = number;
for (int i = 1; i < power; i++)
{
    result *= number;
}

Console.WriteLine(result);