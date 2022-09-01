// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

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

int GetRangeSum(int lowerRange, int upperRange)
{
    if (lowerRange > upperRange)
    {
        return 0;
    }

    return GetRangeSum(lowerRange, upperRange - 1) + upperRange;
}

int lowerRange = Prompt("Введите нижнюю границу диапазона > ");
int upperRange = Prompt("Введите верхнюю границу диапазона > ");

if (CheckUserNum(lowerRange) && CheckUserNum(upperRange))
{
    if (lowerRange < upperRange)
    {
        System.Console.WriteLine(GetRangeSum(lowerRange, upperRange));
    }
    else
    {
        System.Console.WriteLine("Нижняя граница диапазона не может быть больше " +
        "верхней или равняться ей");
    }
}
else
{
    System.Console.WriteLine("Числа должны быть положительными");
}
