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
    }
}
