namespace Sorting.sorting.specials;

class BucketSort
{
    void BucketSort(double[] array)
    {
        int tamanho = array.Length;
        List<double>[] baldes = new List<double>[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            baldes[i] = new List<double>();
        }

        foreach (double valor in array)
        {
            int indice = (int)(valor * tamanho);
            baldes[indice].Add(valor);
        }

        for (int i = 0; i < tamanho; i++)
        {
            baldes[i].Sort();
        }

        int posicao = 0;
        for (int i = 0; i < tamanho; i++)
        {
            foreach (double valor in baldes[i])
            {
                array[posicao++] = valor;
            }
        }
    }

}
