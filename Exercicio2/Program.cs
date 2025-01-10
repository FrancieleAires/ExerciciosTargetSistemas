using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------- EXERCÍCIO 2 - TARGET SISTEMAS -------------");
        Console.WriteLine();
        Console.WriteLine("Informe um número para verificar na sequência de Fibonacci:");
        int numero = int.Parse(Console.ReadLine());
        int a = 0, b = 1, temp = 0;

        bool pertence = false;

        while (temp <= numero)
        {
            if (temp == numero)
            {
                pertence = true;
                break;
            }
            temp = a + b;
            a = b;
            b = temp;
        }

        if (pertence)
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
    }
}
