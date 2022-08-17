// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными
// числами и выводит их на экран. Также ищет второй максимум (число меньше
// максимального элемента, но больше всех остальных) Оформите заполнение массива
// и вывод в виде функции (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//  -> 8

int[] ArrayFill(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 10);
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

int SearchSecondMaxDigit(int[] arr)
{
    int maxNum = arr[0];
    int secondMaxNum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (maxNum < arr[i]) maxNum = arr[i];
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (secondMaxNum < arr[i] && maxNum > arr[i]) secondMaxNum = arr[i];
    }

    return secondMaxNum;
}

int[] array = ArrayFill(8);
ArrayPrint(array);
System.Console.WriteLine("");
System.Console.Write($"Второй максимальный элемент массива: {SearchSecondMaxDigit(array)}");
