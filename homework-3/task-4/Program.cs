int[] arrayFill(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + "\t");
    }

}

int[] Sort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = i; j > 0 && arr[j] < arr[j - 1]; j--)
        {
            int temp = arr[j - 1];
            arr[j - 1] = arr[j];
            arr[j] = temp;
        }
    }
    return arr;
}

int[] array = arrayFill(10);
printArray(array);
System.Console.WriteLine("");
Sort(array);
printArray(array);
