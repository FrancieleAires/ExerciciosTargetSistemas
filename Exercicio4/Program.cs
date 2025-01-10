using System;

class Program
{
    static void Main(string[] args)
    {
        double sp = 67836.43, rj = 36678.66, mg = 29229.88, es = 27165.48, outros = 19849.53;
        double total = sp + rj + mg + es + outros;

        Console.WriteLine("----------- EXERCÍCIO 4 - TARGET SISTEMAS -------------");
        Console.WriteLine();
        Console.WriteLine($"SP: {sp / total:P}");
        Console.WriteLine($"RJ: {rj / total:P}");
        Console.WriteLine($"MG: {mg / total:P}");
        Console.WriteLine($"ES: {es / total:P}");
        Console.WriteLine($"Outros: {outros / total:P}");
    }
}