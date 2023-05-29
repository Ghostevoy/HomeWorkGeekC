
int[] ArrRand(int n)
{
    int[] arr = new int[n];
    var rand = new Random();
    for (int i = 0; i < n; i++)
    {
        arr[i] = rand.Next(1, 1000);
    }

    

    return arr;
}

void Sort(int[] array)
{
    for (int i = array.Length / 2 - 1; i >= 0; i--)
    {
        heapify(array, array.Length, i);
    }
    for (int i = array.Length - 1; i >= 0; i--)
    {
        int temp = array[0];
        array[0] = array[i];
        array[i] = temp;

        heapify(array, i, 0);
    }
}

void heapify(int[] array, int heapSize, int rootIndex)
{
    int largest = rootIndex;
    int leftChild = 2 * rootIndex + 1;
    int rightChild = 2* rootIndex + 2;

    if (leftChild < heapSize && array[leftChild] > array[largest])
    {
        largest = leftChild;
    }
    if (rightChild < heapSize && array[rightChild] > array[largest])
    {
        largest = rightChild;
    }

    if (largest != rootIndex)
    {
        int temp = array[rootIndex];
        array[rootIndex] = array[largest];
        array[largest] = temp;

        heapify(array, heapSize, largest);
    }
}


int[] array = ArrRand(100);
Console.WriteLine(string.Join(' ', array));
Sort(array);

Console.WriteLine(string.Join(' ', array));
