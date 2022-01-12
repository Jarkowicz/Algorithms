// See https://aka.ms/new-console-template for more information
Console.WriteLine("Convert decimal number to binary");
Console.WriteLine("Enter decimal number");

var parsed = int.TryParse(Console.ReadLine(), out int input);

if(parsed)
{
    Console.WriteLine(ConvertToBinary(input));
}

string ConvertToBinary(int input)
{
    var binary = "";
    while(input > 0)
    {
        var binaryDigit = input % 2;
        binary += binaryDigit;
        input /= 2;
    }
    var result = "";
    for (int i = binary.Length - 1 ; i >= 0 ; i--)
    {
        result += binary[i];
    }

    return result;
}