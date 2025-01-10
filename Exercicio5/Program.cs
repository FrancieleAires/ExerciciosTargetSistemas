using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------- EXERCÍCIO 4 - TARGET SISTEMAS -------------");
        Console.WriteLine();
        Console.WriteLine("Digite uma string para inverter:");
        string input = Console.ReadLine();
        string invertida = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            invertida += input[i];
        }

        Console.WriteLine($"String invertida: {invertida}");

        //Dessa forma, não se torna necessário usar o Reverse, funcionando perfeitamente! Eu gosto de usar essa maneira qnd não é possivel usar o Reverse
    }
}