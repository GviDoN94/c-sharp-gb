// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.

// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

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

int RandomPosNeg()
{
    int random = 1;
    if (new Random().Next(0, 2) == 0)
    {
        return -random;
    }
    return random;
}

double[,] MultiArrayFill(int rows, int columns)
{
    double[,] multiArr = new double[rows, columns];
    for (int i = 0; i < multiArr.GetLength(0); i++)
    {
        for (int j = 0; j < multiArr.GetLength(1); j++)
        {
            double temp = new Random().NextDouble() * 10 * RandomPosNeg();
            multiArr[i, j] = Math.Round(temp, 1);
        }
    }
    return multiArr;
}

void PrintMultiArray(double[,] multiArr)
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

int m = Prompt("Введите колличество строк в массиве > ");
int n = Prompt("Введите колличество колонок в массиве > ");

if (CheckUserNum(m) && CheckUserNum(n))
{
    PrintMultiArray(MultiArrayFill(m, n));
}
else
{
    System.Console.WriteLine("Колличество строк и колонок не может быть отрицательным или равняться нулю");
}
