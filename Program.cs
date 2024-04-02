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

LogicaMergeSort.Executar(arrayTeste);

Extensao.ExibirElementos(arrayTeste);

Console.WriteLine("\n");
Console.WriteLine("Fim do algoritmo Merge Sort.");
Console.ReadLine();