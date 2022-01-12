// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculate sum of the digits");
Console.WriteLine("Enter the number");
var parsed = int.TryParse(Console.ReadLine(), out int input);

Console.WriteLine($"The sum of the digits of the number {input} = {SumOfTheDigits(input)}");

int SumOfTheDigits(int input)
{
    var sum = 0;
    while(input > 0)
    {
        int digit = input % 10;
        sum += digit;
        input /= 10;
    }

    return sum;
}