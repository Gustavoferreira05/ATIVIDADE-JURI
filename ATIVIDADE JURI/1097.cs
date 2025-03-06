// See https://aka.ms/new-console-template for more information
for (int i = 1, jStart = 7; i <= 9; i += 2, jStart += 2)
{
    for (int j = jStart; j >= jStart - 2; j--)
    {
        Console.WriteLine($"I={i} J={j}");
    }
}