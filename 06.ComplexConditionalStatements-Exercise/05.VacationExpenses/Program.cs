string season = Console.ReadLine();
string accomodationType = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

int price = 0;
double multiplier  = 1;
if (season == "Spring") // 20% discount 
{
    multiplier = 0.8;
    if (accomodationType == "Hotel")
    {
        price = 30;

    }
    else
    {
        price = 10;
    }
}
else if (season == "Summer") // 0% discount
{
    if (accomodationType == "Hotel") 
    {
        price = 50;
    }
    else //Camping
    {
        price = 30;
    }
    
}
else if (season == "Autumn") // 30% discount
{
    multiplier = 0.7;
    if(accomodationType == "Hotel") 
    {
        price = 20;
    }
    else //Camping
    {
        price = 15;
    }
}
else // Winter // 10 % discount
{
    multiplier = 0.9;
    if (accomodationType == "Hotel") 
    {
        price = 40;
    }
    else //Camping
    {
        price = 10;
    }
}
double totalPrice  = (price * days) *  multiplier;
Console.WriteLine($"{totalPrice:F2}");