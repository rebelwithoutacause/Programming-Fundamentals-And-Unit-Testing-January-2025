using System;

class Program
{
    static void Main()
    {
        // Read input values
        string typeOfMovie = Console.ReadLine();
        int countOfRows = int.Parse(Console.ReadLine());
        int countOfSeatsPerRow = int.Parse(Console.ReadLine());

        int allSeatsInCinema = countOfRows * countOfSeatsPerRow;
        double priceForATicket = 0;

        switch (typeOfMovie)
        {
            case "Premiere":
                priceForATicket = 12.00;
                break;
            case "Normal":
                priceForATicket = 7.50;
                break;
            case "Discount":
                priceForATicket = 5.00;
                break;
            default:
                Console.WriteLine("Invalid movie type");
                return;
        }

        double finalPrice = allSeatsInCinema * priceForATicket;

        Console.WriteLine($"{finalPrice:F2}");
    }
}
