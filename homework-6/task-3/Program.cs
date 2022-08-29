// Задача 3. Со Звездочкой (*). Сгенерировать двумерный массив со случайными
// числами, вывести его на экран, оформить в виде функций (пригодится в дальнейшем)

int[,] MultiArrayFill(int rows, int columns, int minValue, int maxValue)
{
    int[,] multiArr = new int[rows, columns];
    for (int i = 0; i < multiArr.GetLength(0); i++)
    {
        for (int j = 0; j < multiArr.GetLength(1); j++)
        {
            multiArr[i, j] = new Random().Next(minValue, maxValue);
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

PrintMultiArray(MultiArrayFill(5, 7, 0, 10));
