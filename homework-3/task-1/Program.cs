// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool CheckValidNumber(int value)
{
    return value >= 10000 && value < 100000;
}

bool PalindromeFiveDigit(int value)
{
    int firstDigit = value / 10000;
    int secondDigit = value / 1000 % 10;
    int fourthDigit = value / 10 % 10;
    int fifthDigit = value % 10;

    if (fifthDigit == firstDigit && secondDigit == fourthDigit)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int userNum = Prompt("Введите пятизначное число > ");

if (!CheckValidNumber(userNum))
{
    System.Console.WriteLine("Вы ввели не пятизначное число");
}
else
{
    if (PalindromeFiveDigit(userNum))
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}
