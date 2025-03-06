// See https://aka.ms/new-console-template for more information
int N = int.Parse(Console.ReadLine());

int totalCobaias = 0;
int totalCoelhos = 0;
int totalRatos = 0;
int totalSapos = 0;

for (int i = 0; i < N; i++)
{
    string[] entrada = Console.ReadLine().Split();
    int quantidade = int.Parse(entrada[0]);
    char tipo = char.Parse(entrada[1]);

    totalCobaias += quantidade;

    switch (tipo)
    {
        case 'C':
            totalCoelhos += quantidade;
            break;
        case 'R':
            totalRatos += quantidade;
            break;
        case 'S':
            totalSapos += quantidade;
            break;
    }
}

Console.WriteLine($"Total: {totalCobaias} cobaias");
Console.WriteLine($"Total de coelhos: {totalCoelhos}");
Console.WriteLine($"Total de ratos: {totalRatos}");
Console.WriteLine($"Total de sapos: {totalSapos}");

Console.WriteLine($"Percentual de coelhos: {(totalCoelhos * 100.0 / totalCobaias):F2} %");
Console.WriteLine($"Percentual de ratos: {(totalRatos * 100.0 / totalCobaias):F2} %");
Console.WriteLine($"Percentual de sapos: {(totalSapos * 100.0 / totalCobaias):F2} %");
