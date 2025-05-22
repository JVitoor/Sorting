namespace Sorting.sorting.efficient;

class ShellSort
{
    void ShellSort(int[] array)
    {
        int tamanho = array.Length;
        int intervalo = 1;

        while (intervalo <= tamanho) intervalo = 3 * intervalo + 1;
        while (intervalo > 1)
        {
            intervalo /= 3;

            for (int inicio = 0; inicio < intervalo; inicio++)
            {
                int subTamanho = (tamanho / intervalo) + ((tamanho % intervalo > inicio) ? 1 : 0);
                for (int i = 1; i < subTamanho; i++)
                {
                    int valorAtual = array[(i * intervalo) + inicio];
                    int j = i - 1;
                    while (j >= 0 && array[j * intervalo + inicio] > valorAtual)
                    {
                        array[(j + 1) * intervalo + inicio] = array[j * intervalo + inicio];
                        j--;
                    }
                    array[(j + 1) * intervalo + inicio] = valorAtual;
                }
            }
        }
    }

}
