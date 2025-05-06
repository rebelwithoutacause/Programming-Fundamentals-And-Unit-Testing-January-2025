int n = int.Parse(Console.ReadLine());

PrintTriange(n);

static void PrintTriange(int n)
{
     
    for (int row = 1; row < n; row++)
    {
        PrintLine(1, row);
    }

     
    for (int row = n; row >= 1; row--)
    {
        PrintLine(1, row);
    }
}


static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}