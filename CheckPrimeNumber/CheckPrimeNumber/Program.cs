// See https://aka.ms/new-console-template for more information

Console.WriteLine("Check is it Prime number");
Console.WriteLine("To exit press C");
bool parsed = true;

while (parsed)
{    
    Console.WriteLine("Enter input number:");

    parsed = int.TryParse(Console.ReadLine(), out int result);
    if (parsed)
    {
        var defaultColor = Console.ForegroundColor;
        if(CheckIsPrimeNumber(result, out string output))
            Console.ForegroundColor = ConsoleColor.Green;
        else
            Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(output);
        Console.ForegroundColor = defaultColor;
    }
}

bool CheckIsPrimeNumber(int input, out string output)
{
    output = "Prime number";
    for (int i = 1; i <= input; i++)
    {
        if (i != 1 && i != input && input % i == 0)
        {
            output = "Not prime number";
            return false;
        }
    }
    return true;
}