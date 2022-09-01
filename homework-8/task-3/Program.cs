// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool CheckMultiplicationMatrixes(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        return true;
    }
    return false;
}

int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resultMatrix;
}

int userRowFirstMatrix = Prompt("Введите колличество строк в первой " +
    "матрице ");
int userColumnFirstMatrix = Prompt("Введите колличество колонок в первой " +
    "матрице ");
int userRowSecondMatrix = Prompt("Введите колличество строк во второй " +
    "матрице ");
int userColumnSecondMatrix = Prompt("Введите колличество колонок во второй " +
    "матрице ");

int[,] firstMatrix = MultiArrayFill(userRowFirstMatrix, userColumnFirstMatrix);
int[,] secondMatrix = MultiArrayFill(userRowSecondMatrix, userColumnSecondMatrix);

if (CheckUserNum(userRowFirstMatrix)
    && CheckUserNum(userColumnFirstMatrix)
    && CheckUserNum(userRowSecondMatrix)
    && CheckUserNum(userColumnSecondMatrix)
    )
{
    if (CheckMultiplicationMatrixes(firstMatrix, secondMatrix))
    {
        PrintMultiArray(firstMatrix);
        System.Console.WriteLine();
        PrintMultiArray(secondMatrix);
        System.Console.WriteLine();
        PrintMultiArray(
            MultiplicationMatrix(firstMatrix, secondMatrix)
        );
    }
    else
    {
        System.Console.WriteLine("Нельзя найти произведение данных матриц. " +
        "Колличесто колонок первой матрицы должно равнятся колличеству строк " +
        "второй матрицы!");
    }
}
else
{
    System.Console.WriteLine("Колличество строк и колонок в матрицах не может " +
        "быть отрицательным или равняться нулю");
}
