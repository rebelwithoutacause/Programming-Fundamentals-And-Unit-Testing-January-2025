﻿int n = int.Parse(Console.ReadLine());

List<string> listOfProducts = new List<string>();

for (int i = 0; i < n; i++)
{
    string product = Console.ReadLine();
    listOfProducts.Add(product);
}

listOfProducts.Sort();

for (int i = 0; i < listOfProducts.Count; i++)
{
    Console.WriteLine($"{i + 1}.{listOfProducts[i]}");
}