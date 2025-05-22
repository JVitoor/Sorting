namespace Sorting.sorting.specials;

class CountingSort
{
    int[] CountingSort(int[] array, int valorMaximo)
    {
        int[] contagem = new int[valorMaximo + 1];
        int[] resultado = new int[array.Length];

        foreach (int numero in array)
        {
            contagem[numero]++;
        }

        for (int i = 1; i <= valorMaximo; i++)
        {
            contagem[i] += contagem[i - 1];
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            int valor = array[i];
            resultado[contagem[valor] - 1] = valor;
            contagem[valor]--;
        }

        return resultado;
    }

}
