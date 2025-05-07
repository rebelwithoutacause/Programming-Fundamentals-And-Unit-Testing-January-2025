int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < n; i++)
{
    int currNum = int.Parse(Console.ReadLine());
    numbers[i] = currNum;
}

Array.Reverse(numbers);

Console.WriteLine(string.Join(" ", numbers));