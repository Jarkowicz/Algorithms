// See https://aka.ms/new-console-template for more information
Console.WriteLine("Reverse number");
Console.WriteLine("Enter the number:");
var parsed = int.TryParse(Console.ReadLine(), out int input);

if (!parsed)
    Console.WriteLine("Cannot parse the number!");
else
    Console.WriteLine(ReverseNumber(input));

int ReverseNumber(int input)
{
    int reversedNumber = 0;
    while (input > 0)
    {
        var digit = input % 10;        
        reversedNumber = reversedNumber * 10 + digit;        
        input /= 10;
    }
    return reversedNumber;
}