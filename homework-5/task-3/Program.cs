// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 7

int RandomPosNeg()
{
    int random = 1;
    if (new Random().Next(0, 2) == 0)
    {
        return -random;
    }
    return random;
}

double[] ArrayFill(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        double temp = new Random().NextDouble() * 100 * RandomPosNeg();
        arr[i] = Math.Round(temp, 1);
    }

    return arr;
}

void ArrayPrint(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} \t");
    }
}

double diffMinElMaxElArr(double[] arr)
{
    double maxEl = arr[0];
    double minEl = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxEl) maxEl = arr[i];
        if (arr[i] < minEl) minEl = arr[i];
    }

    return maxEl - minEl;
}

double[] array = ArrayFill(10);
ArrayPrint(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diffMinElMaxElArr(array)}");
