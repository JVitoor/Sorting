namespace Sorting.sorting.efficient;

class QuickSort
{
    void QuickSort(int[] array, int inicio, int fim)
    {
        int esquerda = inicio;
        int direita = fim;
        int pivo = array[(inicio + fim) / 2];

        while (esquerda <= direita)
        {
            while (array[esquerda] < pivo) esquerda++;
            while (array[direita] > pivo) direita--;

            if (esquerda <= direita)
            {
                int temp = array[esquerda];
                array[esquerda] = array[direita];
                array[direita] = temp;
                esquerda++;
                direita--;
            }
        }

        if (inicio < direita) QuickSort(array, inicio, direita);
        if (esquerda < fim) QuickSort(array, esquerda, fim);
    }

}
