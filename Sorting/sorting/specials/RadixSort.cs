namespace Sorting.sorting.specials;

class RadixSort
{
    void RadixSort(int[] array)
    {
        int maiorValor = array.Max();
        int expoente = 1;

        while (maiorValor / expoente > 0)
        {
            CountingSortPorDigito(array, expoente);
            expoente *= 10;
        }
    }

    void CountingSortPorDigito(int[] array, int expoente)
    {
        int tamanho = array.Length;
        int[] resultado = new int[tamanho];
        int[] contagem = new int[10];

        for (int i = 0; i < tamanho; i++)
        {
            int digito = (array[i] / expoente) % 10;
            contagem[digito]++;
        }

        for (int i = 1; i < 10; i++)
        {
            contagem[i] += contagem[i - 1];
        }

        for (int i = tamanho - 1; i >= 0; i--)
        {
            int digito = (array[i] / expoente) % 10;
            resultado[contagem[digito] - 1] = array[i];
            contagem[digito]--;
        }

        for (int i = 0; i < tamanho; i++)
        {
            array[i] = resultado[i];
        }
    }

}
