// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] InsertionSortRowsMaxToMinInMultiArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            for (int k = j; k > 0 && arr[i, k] > arr[i, k - 1]; k--)
            {
                int temp = arr[i, k - 1];
                arr[i, k - 1] = arr[i, k];
                arr[i, k] = temp;
            }
        }
    }
    return arr;
}

int userRows = Prompt("Введите количество строк > ");
int userColumns = Prompt("Введите колличество колонок > ");

if (CheckUserNum(userRows) && CheckUserNum(userColumns))
{
    int[,] matrix = MultiArrayFill(userRows, userColumns);
    PrintMultiArray(matrix);
    System.Console.WriteLine();

    PrintMultiArray(InsertionSortRowsMaxToMinInMultiArray(matrix));
}
else
{
    System.Console.WriteLine("Колличество строк и колонок не может быть " +
        "отрицательным или равняться нулю");
}

