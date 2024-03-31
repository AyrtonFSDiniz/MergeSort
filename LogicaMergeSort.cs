namespace MergeSort
{
    public static class LogicaMergeSort
    {
        public static void Executar(List<int> array)
        {
            Sort(array, 0, array.Count - 1);
        }

        private static void Sort(List<int> array, int primeiraPosicao, int ultimaPosicao)
        {
            if (ValidacaoDosParametros(array, primeiraPosicao, ultimaPosicao))
            {
                int meio = ((primeiraPosicao + ultimaPosicao) / 2);

                Extensao.ExibindoAlgoritmo(array, primeiraPosicao, ultimaPosicao, meio);

                Sort(array, primeiraPosicao, meio);

                Sort(array, meio + 1, ultimaPosicao);

                Merge(array, primeiraPosicao, meio, ultimaPosicao);

            }

        }

        

        private static bool ValidacaoDosParametros(List<int> array, int primeiraPosicao, int ultimaPosicao)
        {
            return array is not null && primeiraPosicao < ultimaPosicao && primeiraPosicao >= 0
                 && ultimaPosicao < array.Count && array.Count != 0;
        }

        private static void Merge(List<int> array, int primeiraPosicao, int meio, int ultimaPosicao)
        {
            int[] aux = new int[array.Count];
            Array.Copy(array.ToArray(), aux, array.Count);

            int i = primeiraPosicao;
            int j = meio + 1;
            int k = primeiraPosicao;

            while (i <= meio && j <= ultimaPosicao)
            {
                if (aux[i] < aux[j])
                {
                    array[k] = aux[i];
                    i++;
                }
                else
                {
                    array[k] = aux[j];
                    j++;
                }

                k++;
            }


            while (i <= meio)
            {
                array[k] = aux[i];
                i++;
                k++;
            }


            while (j <= ultimaPosicao)
            {
                array[k] = aux[j];
                j++;
                k++;
            }
        }
    }
}
