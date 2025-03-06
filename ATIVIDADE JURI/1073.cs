// See https://aka.ms/new-console-template for more information
int N = int.Parse(Console.ReadLine());

for (int i = 2; i <= N; i += 2)
{
    Console.WriteLine($"{i}^2 = {i * i}");
}

