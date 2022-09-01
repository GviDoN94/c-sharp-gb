// Задача 4. Со звездочкой (*) Напишите программу, которая заполнит спирально
// квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] FillSpiralSquareMatrix(int sizeMatrix)
{
    int[,] squareArr = new int[sizeMatrix, sizeMatrix];
    int padding = 0;
    int fillingCount = 1;

    while (sizeMatrix > 0)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < sizeMatrix; j++)
            {
                if (i == 0 && j < sizeMatrix - padding)
                    squareArr[i + padding, j + padding] = fillingCount++;
                if (i == 1 && j < sizeMatrix - padding && j != 0)
                    squareArr[j + padding, sizeMatrix - 1] = fillingCount++;
                if (i == 2 && j < sizeMatrix - padding && j != 0)
                    squareArr[sizeMatrix - 1, sizeMatrix - (j + 1)] = fillingCount++;
                if (i == 3 && j < sizeMatrix - (padding + 1) && j != 0)
                    squareArr[sizeMatrix - (j + 1), padding] = fillingCount++;
            }
        }
        sizeMatrix--;
        padding++;
    }
    return squareArr;
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

int userSizeMatrix = Prompt("Введите размер квадратной матрицы > ");

if (CheckUserNum(userSizeMatrix))
{
    PrintMultiArray(FillSpiralSquareMatrix(userSizeMatrix));
}
else
{
    System.Console.WriteLine("Размер матрицы не может быть отрицательным " +
    "или равняться нулю");
}
