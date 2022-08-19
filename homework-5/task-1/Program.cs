// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int CountEvenNumArr(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }
    
    return count;
}

int[] array = ArrayFill(10, 100, 1000);
ArrayPrint(array);
System.Console.WriteLine();
System.Console.WriteLine($"Колличество четных чисел в массиве: {CountEvenNumArr(array)}");
