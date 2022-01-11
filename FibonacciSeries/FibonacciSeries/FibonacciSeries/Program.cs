// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number to generte fib numbers: ");
int input = int.Parse(Console.ReadLine());
Console.WriteLine(GenerateFibonacciIteration(input));


string GenerateFibonacciIteration(int input)
{
    var n0 = 0;
    var n1 = 1;
    string series = $"{n0} {n1}";
    for (int i = 2; i < input; i++)
    {
        var n2 = n0 + n1;
        series += $" {n2}";
        n0 = n1;
        n1 = n2;
    }

    return series;
}
