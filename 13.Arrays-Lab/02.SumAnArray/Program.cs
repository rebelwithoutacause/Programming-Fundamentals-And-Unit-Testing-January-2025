
int[] numbersArray = Console.ReadLine()        
                            .Split(" ")        
                            .Select(int.Parse)
                            .ToArray();        

int sum = 0;

for (int i = 0; i < numbersArray.Length; i++)
{
    int currentNumber = numbersArray[i];

    sum += currentNumber;
}

Console.WriteLine(sum);