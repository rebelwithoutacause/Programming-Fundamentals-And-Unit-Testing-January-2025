string number = Console.ReadLine();

int sum = 0;

for (int i = 0; i < number.Length; i++)
{
   
    int currentDigit = int.Parse(number[i].ToString());

    if (currentDigit % 2 == 0)
    {
        int currentFactorial = FactorialRecursive(currentDigit);
        sum += currentFactorial;
    }
}

Console.WriteLine(sum);

// метод за изчисление на факториел от ChatGPT
static int FactorialRecursive(int n)
{
    if (n == 0 || n == 1)
        return 1;
    return n * FactorialRecursive(n - 1);
}