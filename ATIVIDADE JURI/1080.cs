// See https://aka.ms/new-console-template for more information
int maiorValor = int.MinValue;
int posicao = 0;

for (int i = 1; i <= 100; i++)
{
    int numero = int.Parse(Console.ReadLine());

    if (numero > maiorValor)
    {
        maiorValor = numero;
        posicao = i;
    }
}

Console.WriteLine(maiorValor);
Console.WriteLine(posicao);

