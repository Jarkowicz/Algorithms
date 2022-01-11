// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number to generate factorial number:");
bool parsed = int.TryParse(Console.ReadLine(), out int input);
if(parsed)
{
    Console.WriteLine("factorial number: {0}! = {1}", input, GenerateFactorialNumber(input));
}
Console.WriteLine();

int GenerateFactorialNumber(int input)
{
    int result = 1;
    for (int i = input; i > 1; i--)
    {
        result *= i;
    }

    return result;
}