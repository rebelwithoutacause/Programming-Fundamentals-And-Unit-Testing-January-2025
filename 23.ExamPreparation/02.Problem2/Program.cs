int[] numbers = Console.ReadLine()
                       .Split(" ")
                       .Select(int.Parse)
                       .ToArray();

int leftMiddleIndex = numbers.Length / 2 - 1;

int rigthMiddlIndex = numbers.Length / 2;

int sum = numbers[leftMiddleIndex] + numbers[rigthMiddlIndex];

double averageResult = sum / 2.0;

Console.WriteLine($"{averageResult:F2}");