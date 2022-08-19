// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

int[] ArrayFill(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }

    return arr;
}

void ArrayPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} \t");
    }
}

int SumNumOddPos(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }

    return sum;
}

int[] array = ArrayFill(5, -99, 100);
ArrayPrint(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов на нечетных позициях в массиве: {SumNumOddPos(array)}");
