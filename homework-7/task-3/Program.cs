// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool CheckUserNum(int userNum)
{
    return userNum > 0;
}

int[,] MultiArrayFill(int rows, int columns)
{
    int[,] multiArr = new int[rows, columns];
    for (int i = 0; i < multiArr.GetLength(0); i++)
    {
        for (int j = 0; j < multiArr.GetLength(1); j++)
        {
            multiArr[i, j] = new Random().Next(0, 10);
        }
    }
    return multiArr;
}

void PrintMultiArray(int[,] multiArr)
{
    for (int i = 0; i < multiArr.GetLength(0); i++)
    {
        for (int j = 0; j < multiArr.GetLength(1); j++)
        {
            System.Console.Write(multiArr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] CalcAverageArrayColumns(int[,] arr)
{
    double[] resultAverageArr = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double averageColumn = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            averageColumn += arr[j, i];
        }
        averageColumn /= arr.GetLength(0);
        resultAverageArr[i] = Math.Round(averageColumn, 1);
    }
    return resultAverageArr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}\t");
    }
}

int rows = Prompt("Введите количество строк > ");
int columns = Prompt("Введите колличество колонок > ");

if (CheckUserNum(rows) && CheckUserNum(columns))
{
    int[,] array = MultiArrayFill(rows, columns);

    PrintMultiArray(array);
    PrintArray(CalcAverageArrayColumns(array));
}
else
{
    System.Console.WriteLine("Колличество строк и колонок не может быть отрицательным или равняться нулю");
}
