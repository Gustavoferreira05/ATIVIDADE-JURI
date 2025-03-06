// See https://aka.ms/new-console-template for more information
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    int X = int.Parse(Console.ReadLine());

    if (X == 0)
    {
        Console.WriteLine("NULL");
    }
    else
    {
        string parity = (X % 2 == 0) ? "EVEN" : "ODD";
        string sign = (X > 0) ? "POSITIVE" : "NEGATIVE";
        Console.WriteLine($"{parity} {sign}");
    }
