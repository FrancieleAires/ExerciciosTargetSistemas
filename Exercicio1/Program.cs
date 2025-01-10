using System;

class Program
{
    static void Main(string[] args)
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("----------- EXERCÍCIO 1 - TARGET SISTEMAS -------------");
        Console.WriteLine();
        Console.WriteLine($"O valor final de SOMA é: {SOMA}");
        // O valor que vai retornar aqui será 91, está funcionando!! 
    }
}