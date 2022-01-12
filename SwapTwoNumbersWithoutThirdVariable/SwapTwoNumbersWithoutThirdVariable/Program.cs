// See https://aka.ms/new-console-template for more information
Console.WriteLine("Swap two numbers without third variable");
Console.WriteLine("Enter first number:");
var parsed1 = int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Enter scond number:");
var parsed2 = int.TryParse(Console.ReadLine(), out int b);

if (parsed1 && parsed2)
{
    Console.WriteLine("Swap");
    Console.WriteLine($"Before swap a = {a} b = {b}");
    Swap(ref a, ref b);
    Console.WriteLine($"After swap a = {a} b = {b}");
    Console.WriteLine("Swap2");
    Console.WriteLine($"Before swap a = {a} b = {b}");
    Swap2(ref a, ref b);
    Console.WriteLine($"After swap a = {a} b = {b}");
}

void Swap(ref int a, ref int b)
{
    // a = 1
    // b = 2
    b = a + b; // b = 1 + 2 = 3
    a = b - a; // a = 3 - 1 = 2 OK :)
    b = b - a; // b = 3 - 2 = 1 OK :)
}

void Swap2 (ref int a, ref int b)
{
    // a = 1
    // b = 2
    b = a * b; // b = 1 * 2 = 2
    a = b / a; // a = 2 / 1 = 2 OK :)
    b = b / a; // b = 2 / 2 = 1 OK :)
}