double depositAmount = double.Parse(Console.ReadLine());
int countOfMonths = int.Parse(Console.ReadLine());
double interestPercentPerYear = double.Parse(Console.ReadLine());

double yearIncome = depositAmount * interestPercentPerYear / 100;
double monthIncome = yearIncome / 12;
double finalAmount = depositAmount + countOfMonths * monthIncome;

Console.WriteLine($"{finalAmount:F2}");