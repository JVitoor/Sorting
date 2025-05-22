namespace Sorting.sorting.efficient;

class HeapSort
{
    void HeapSort(int[] array)
    {
        int tamanho = array.Length;

        for (int i = tamanho / 2 - 1; i >= 0; i--)
        {
            AjustarHeap(array, tamanho, i);
        }

        for (int i = tamanho - 1; i >= 0; i--)
        {
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            AjustarHeap(array, i, 0);
        }
    }

    void AjustarHeap(int[] array, int tamanho, int indice)
    {
        int maior = indice;
        int esquerda = 2 * indice + 1;
        int direita = 2 * indice + 2;

        if (esquerda < tamanho && array[esquerda] > array[maior]) maior = esquerda;
        if (direita < tamanho && array[direita] > array[maior]) maior = direita;

        if (maior != indice)
        {
            int temp = array[indice];
            array[indice] = array[maior];
            array[maior] = temp;

            AjustarHeap(array, tamanho, maior);
        }
    }

}
