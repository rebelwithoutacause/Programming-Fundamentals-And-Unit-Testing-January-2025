int numberOfPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int countOfDaysNeeded = int.Parse(Console.ReadLine());

int neededHours = numberOfPages / pagesPerHour;

int readingHoursPerDay = neededHours / countOfDaysNeeded;

Console.WriteLine(readingHoursPerDay);