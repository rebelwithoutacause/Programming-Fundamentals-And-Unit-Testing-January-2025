int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int num = start; num <= end; num++)
{
    
    int primeCounter = 0;

    for (int i = 1; i <= num; i++)
    {
        
        if (num % i == 0)
        {
            primeCounter++;
        }
    }

    
    if (primeCounter == 2)
    {
        Console.Write($"{num} ");
    }
}