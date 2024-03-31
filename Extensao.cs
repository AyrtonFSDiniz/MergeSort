namespace MergeSort
{
    public static class Extensao
    {
        public static void ExibirElementos(List<int> array)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"### Valores finais do MergeSort ###");
            Console.WriteLine("\n");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.WriteLine($"{i + 1}º: {array[i]}");
            }
        }

        public static void ExibindoAlgoritmo(List<int> array, int primeiraPosicao, int ultimaPosicao, int meio)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Primeira posição: {primeiraPosicao} - Valor: {array[primeiraPosicao]}");
            Console.WriteLine($"Posição do meio: {meio} - Valor: {array[meio]}");
            Console.WriteLine($"Última posição: {ultimaPosicao} - Valor: {array[ultimaPosicao]}");
            Console.WriteLine("\n");
        }
    }
}
