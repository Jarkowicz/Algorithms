// See https://aka.ms/new-console-template for more information
Console.WriteLine("Number in characters (Convert number to characters)");
Console.WriteLine("Enter the number:");

var digitAsString = new[]
{
    "Zero",
    "One",
    "Two",
    "Three",
    "Four",
    "Five",
    "Six",
    "Seven",
    "Eight",
    "Nine"
};

var parsed = int.TryParse(Console.ReadLine(), out int input);

if(parsed)
{
    Console.WriteLine(GenerateNumberToChars(input));
}

string GenerateNumberToChars(int input)
{
    string result = "";
    List<string> numberWords = new List<string>(); 
    while(input > 0)
    {
        var digit = input % 10;
        numberWords.Add(digitAsString[digit]);
        input /= 10;
    }

    for (int i = numberWords.Count() - 1; i >= 0 ; i--)
    {
        result += numberWords[i] + " ";
    }

    return result.TrimEnd();
}