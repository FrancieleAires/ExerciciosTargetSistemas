using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string para inverter:");
        string input = Console.ReadLine();
        string invertida = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            invertida += input[i];
        }

        Console.WriteLine($"String invertida: {invertida}");

        //Dessa maneira não é necessário usar o Reverse, e funciona perfeitamente!
    }
}
