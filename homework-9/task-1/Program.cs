// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

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

void ShowOddDigits(int lowerRange, int upperRange)
{
    if (lowerRange > upperRange)
    {
        return;
    }
    else if (upperRange % 2 == 1)
    {
        --upperRange;
    }

    ShowOddDigits(lowerRange, upperRange - 2);
    System.Console.Write(upperRange + "\t ");
}

int lowerRange = Prompt("Введите нижнюю границу диапазона > ");
int upperRange = Prompt("Введите верхнюю границу диапазона > ");

if (CheckUserNum(lowerRange) && CheckUserNum(upperRange))
{
    if (lowerRange < upperRange)
    {
        ShowOddDigits(lowerRange, upperRange);
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
