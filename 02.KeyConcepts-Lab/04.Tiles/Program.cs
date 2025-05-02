using System;
using System.Data;
//Input
double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeigth = double.Parse(Console.ReadLine());

double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

//Calculations
double roomArea = bathroomWidth * bathroomHeigth;
double tileArea = tileWidth * tileHeight;
double tiles = roomArea / tileArea * 1.1;
Console.WriteLine(Math.Round(tiles));