// See https://aka.ms/new-console-template for more information
int N = int.Parse(Console.ReadLine());
int[] numeros = new int[10000];
int index = 0;
        for (int i = 1; i <= 10000; i++)
        {
            if (i % N == 2)
            {
                numeros[index] = i;
                index++;
            }
        }

       
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    


