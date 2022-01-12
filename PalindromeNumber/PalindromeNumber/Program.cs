// See https://aka.ms/new-console-template for more information
Console.WriteLine("Check palindrome number");
Console.WriteLine("Enter number");
string input = Console.ReadLine();

Console.WriteLine(CheckIsItPalindromeNumber(input));
Console.WriteLine(CheckIsItPalindromeNumber2(input));

Console.ReadLine();


string CheckIsItPalindromeNumber(string input)
{
    if (input == null) return "Null";
    var parsed = int.TryParse(input, out int r);
    if (!parsed) return "NaN";
    
    var result = ":) Palindrome number!";

    for (int i = 0; i < input.Length; i++)
    {
        var lastIndex = (input.Length - 1);
        var firstCharacter = input[i];
        var lastCharacter = input[lastIndex - i];
        if (firstCharacter != lastCharacter)
        {
            result = ":( Not Palindorme number!";
        }
    }


    return result;
}

string CheckIsItPalindromeNumber2(string input)
{
    if (input == null) return "Null";
    var parsed = int.TryParse(input, out int n);
    if (!parsed) return "NaN";

    int sum = 0;
    int inputN = n;

    while (n > 0)
    {
        var modulo = n % 10;
        sum = sum*10 + modulo;
        n /= 10;
    }

    if (inputN == sum)
        return ":) Palindrome number!";
    else
        return ":( Not palindrome number!";
}