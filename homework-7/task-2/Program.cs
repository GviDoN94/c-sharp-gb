// Задача 2: Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

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

bool CheckArrayElement(int[,] arr, int row, int column)
{
    if (row <= arr.GetLength(0) && column <= arr.GetLength(1))
    {
        return true;
    }
    return false;
}

int row = Prompt("Введите количество строк массива > ");
int column = Prompt("Введите количество колонок массива > ");

if (CheckUserNum(row) && CheckUserNum(column))
{
    int[,] array = MultiArrayFill(row, column);

    PrintMultiArray(array);

    int rowPosition = Prompt("Введите позицию строки элемента > ");
    int columnPosition = Prompt("Введите позицию колонки элемента > ");

    if (CheckArrayElement(array, rowPosition, columnPosition))
    {
        System.Console.WriteLine(array[--rowPosition, --columnPosition]);
    }
    else
    {
        System.Console.WriteLine("В массиве нет элеманта с указанной позицией");
    }
}
else
{
    System.Console.WriteLine("Колличество строк и колонок не может быть отрицательным или равняться нулю");
}



