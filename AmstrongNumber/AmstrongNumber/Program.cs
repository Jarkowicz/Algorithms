// See https://aka.ms/new-console-template for more information
Console.WriteLine("Check Amstrong number");
Console.WriteLine("Enter the number:");
var inputStr = Console.ReadLine();
var parsed = int.TryParse(inputStr, out int input);

if (!parsed)
    Console.WriteLine("Cannot parse to Integer");
else
    Console.WriteLine(CheckIsAmstrongNumber(input, inputStr != null ? inputStr.Length : 0));

string CheckIsAmstrongNumber(int input, int inputLength)
{
    int sumPower = 0;
    int inputNumber = input;

    while(input > 0)
    {
        var r = input % 10;
        sumPower += (int)Math.Pow(r, inputLength);
        input /= 10;
    }

    if (sumPower == inputNumber)
        return "Amstrong number :)";
    else
        return "Not Amstrong number :(";
}