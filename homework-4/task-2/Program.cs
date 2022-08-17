// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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

int SumDigitsInNumber(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }

    return result;
}

int userNum = Prompt("Введите число > ");

if (!CheckUserNum(userNum))
{
    System.Console.WriteLine("Нужно ввести положительное число");
}
else
{
    System.Console.WriteLine(SumDigitsInNumber(userNum));
}
