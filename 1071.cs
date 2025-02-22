/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        int Numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número:");
        int Numero2 = int.Parse(Console.ReadLine());

        
        if (Numero1 > Numero2)
        {
            int Validacao = Numero1;
            Numero1 = Numero2;
            Numero2 = Validacao;
        }

        int soma = 0;

       
        for (int i = Numero1 + 1; i < Numero2; i++)
        {
            if (i % 2 != 0){
                soma += i;
            }
        }

        
        Console.WriteLine(soma);
    }
}
