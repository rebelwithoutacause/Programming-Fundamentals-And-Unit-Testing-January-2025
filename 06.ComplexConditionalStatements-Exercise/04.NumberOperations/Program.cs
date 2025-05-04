double num1 = int.Parse(Console.ReadLine());
double num2 = int.Parse(Console.ReadLine());
string @operator  = Console.ReadLine();

if (@operator == "+") 
{
    Console.WriteLine($"{num1} {@operator} {num2} = {(num1 + num2):F2}");
}
else if (@operator == "-") 
{
    Console.WriteLine ($"{num1} {@operator} {num2} = {(num1 - num2):F2}");
}
else if (@operator == "*") 
{
    Console.WriteLine ($"{num1} {@operator} {num2} = {(num1 * num2):F2}");
}
else if (@operator == "/") 
{
    Console.WriteLine ($"{num1} {@operator} {num2} = {(num1 / num2):F2}");
}
