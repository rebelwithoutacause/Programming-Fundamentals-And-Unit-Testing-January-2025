string product = (Console.ReadLine());

if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon") 
{
    Console.WriteLine("fruit");
}
else if (product == "cucumber" || product == "pepper" || product == "carrot") 
{
    Console.WriteLine("vegetable");
}
else 
{
    Console.WriteLine("unknown");
}


// Вариант със switch

string productType = Console.ReadLine();
switch (productType)
{
    case "banana" or "apple" or "kiwi" or "cherry" or "lemon":
        Console.WriteLine("fruit");
        break;
    case "cucumber" or "pepper" or "carrot":
        Console.WriteLine("vegetable");
        break;
    default:
        Console.WriteLine("unknown");
        break;