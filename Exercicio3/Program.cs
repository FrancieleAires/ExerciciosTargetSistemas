using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using TargetSistemas;

class Program
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText("faturamento.json"); // O exemplo que eu dei aqui foi: {"faturamento": [10.0, 20.0, 0.0, ...]}
        var dados = JsonSerializer.Deserialize<Faturamentos>(json);

        var valores = dados.Faturamento.Where(v => v > 0).ToArray();
        double media = valores.Average();
        int diasAcimaDaMedia = valores.Count(v => v > media);


        Console.WriteLine("----------- EXERCÍCIO 3 - TARGET SISTEMAS -------------");
        Console.WriteLine();

        Console.WriteLine($"Menor valor: {valores.Min():C}");
        Console.WriteLine($"Maior valor: {valores.Max():C}");
        Console.WriteLine($"Dias acima da média: {diasAcimaDaMedia}");
    }
}