//Input

using System.Data.SqlTypes;

int packsOfPens = int.Parse(Console.ReadLine());
int packsOfMarkers = int.Parse(Console.ReadLine());
int litersOfBoardCleaner = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

//Calculation
double priceOfPens = packsOfPens * 5.80;
double priceOfMarkers = packsOfMarkers * 7.20;
double priceOfLitersOfBordCleaner = litersOfBoardCleaner * 1.20;

double priceForAllMaterials = priceOfPens + priceOfMarkers + priceOfLitersOfBordCleaner;

double discount = priceForAllMaterials * discountPercentage / 100;

double finalPrice = priceForAllMaterials - discount;

//Output
Console.WriteLine(finalPrice);