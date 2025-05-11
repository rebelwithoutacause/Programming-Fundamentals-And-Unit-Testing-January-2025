int number = int.Parse(Console.ReadLine());

int sum = 0;

while (number > 0)
{
 
    int lastDigit = number % 10;

    if (lastDigit % 2 == 0)
    {
        int currentFactorial = CalculateFactorial(lastDigit);
        sum += currentFactorial;
    }

    number /= 10;
}

Console.WriteLine(sum);

static int CalculateFactorial(int num)
{
    int factorial = 1;

    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }

    return factorial;
}