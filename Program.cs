using MergeSort;


Console.WriteLine("\n");
Console.WriteLine(@"Informe os valores para teste do algoritmo Merge Sort 
(digite 'fim' para encerrar):");

List<int> arrayTeste = new List<int>();

string input;
while ((input = Console.ReadLine()) != "fim")
{
    if (int.TryParse(input, out int valor))
    {
        arrayTeste.Add(valor);
    }
    else
    {
        Console.WriteLine("Valor inválido. Tente novamente.");
    }
}

Console.WriteLine($"### Valores iniciais para exemplo do MergeSort ###");
Console.WriteLine("\n");

for (int i = 0; i < arrayTeste.Count(); i++)
{
    Console.WriteLine($"{i + 1}º: {arrayTeste[i]}");
}

LogicaMergeSort.Executar(arrayTeste);

Extensao.ExibirElementos(arrayTeste);