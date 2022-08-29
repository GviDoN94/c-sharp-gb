// Задача 4. Со звездочкой(*). Найдите максимальное значение в матрице по каждой
// строке, ссумируйте их. Затем найдети минимальное значение по каждой колонке,
// тоже ссумируйте их. Затем из первой суммы (с максимумами) вычтите вторую
// сумму(с минимумами)

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

int CalcMaxNumRows(int[,] arr)
{
    int sumMaxNum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int maxNumRow = arr[i, 0];
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > maxNumRow)
            {
                maxNumRow = arr[i, j];
            }
        }
        sumMaxNum += maxNumRow;
    }
    return sumMaxNum;
}

int CalcMinNumColumns(int[,] arr)
{
    int sumMinNum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int minNumColumn = arr[0, i];
        for (int j = 1; j < arr.GetLength(0); j++)
        {
            if (arr[j, i] < minNumColumn)
            {
                minNumColumn = arr[j, i];
            }
        }
        sumMinNum += minNumColumn;
    }
    return sumMinNum;
}

int DifferenceNum(int num1, int num2)
{
    return num1 - num2;
}

int rows = Prompt("Введите количество строк > ");
int columns = Prompt("Введите колличество колонок > ");

if (CheckUserNum(rows) && CheckUserNum(columns))
{
    int[,] array = MultiArrayFill(rows, columns);

    PrintMultiArray(array);

    System.Console.WriteLine("Сумма максимальных чисел в строках: " +
        CalcMaxNumRows(array));

    System.Console.WriteLine("Сумма минимальных чисел в колонках: " +
        CalcMinNumColumns(array));

    System.Console.WriteLine("Разница между суммой максимальных чисел " +
        "в строках и суммой минимальных чисел в колонках: " +
        DifferenceNum(CalcMaxNumRows(array), CalcMinNumColumns(array))
        );
}
else
{
    System.Console.WriteLine("Колличество строк и колонок не может быть " +
        "отрицательным или равняться нулю");
}
