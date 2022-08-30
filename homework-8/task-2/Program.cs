// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

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

int[] SumElemsInRow(int[,] arr)
{
    int[] elemensSumsArr = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sumEls = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumEls += arr[i, j];
        }
        elemensSumsArr[i] = sumEls;
    }

    return elemensSumsArr;
}

int NumberMinElementInArray(int[] arr)
{

    int numMinEl = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[numMinEl])
        {
            numMinEl = i;
        }
    }
    return ++numMinEl;
}


int userRows = Prompt("Введите количество строк > ");
int userColumns = Prompt("Введите колличество колонок > ");

if (CheckUserNum(userRows) && CheckUserNum(userColumns))
{
    int[,] matrix = MultiArrayFill(userRows, userColumns);
    PrintMultiArray(matrix);
    System.Console.WriteLine();

    int numRow = NumberMinElementInArray(
        SumElemsInRow(matrix)
        );
    System.Console.WriteLine($"Наименьшея сумма элеменетов в строке № {numRow}");
}
else
{
    System.Console.WriteLine("Колличество строк и колонок не может быть " +
        "отрицательным или равняться нулю");
}
