namespace _03.BiggestOfFiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            int currentBiggestNumber = int.MinValue;

            if (num1 > currentBiggestNumber)
            {
                currentBiggestNumber = num1; 
            }
            if (num2 > currentBiggestNumber) 
            {
                currentBiggestNumber = num2; 
            }
            if (num3 > currentBiggestNumber);
            {
                currentBiggestNumber = num3; 
            }
            if (num4 > currentBiggestNumber) 
            {
                currentBiggestNumber = num4;
            }
            if (num5 > currentBiggestNumber) 
            {
                currentBiggestNumber = num5;
            }
            Console.WriteLine(currentBiggestNumber); 
        }
    }
}
