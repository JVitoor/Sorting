namespace Sorting.sorting.efficient;

class MergeSort
{
    void MergeSort(int[] array, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int meio = (inicio + fim) / 2;
            MergeSort(array, inicio, meio);
            MergeSort(array, meio + 1, fim);
            Merge(array, inicio, meio, fim);
        }
    }

    void Merge(int[] array, int inicio, int meio, int fim)
    {
        int[] temporario = new int[fim - inicio + 1];
        int i = inicio, j = meio + 1, k = 0;

        while (i <= meio && j <= fim)
        {
            temporario[k++] = array[i] <= array[j] ? array[i++] : array[j++];
        }

        while (i <= meio) temporario[k++] = array[i++];
        while (j <= fim) temporario[k++] = array[j++];

        for (int l = 0; l < temporario.Length; l++)
        {
            array[inicio + l] = temporario[l];
        }
    }
}
