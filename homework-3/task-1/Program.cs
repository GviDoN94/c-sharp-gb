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

void PalindromeFiveDigit(int value)
{
    if (value >= 10000 && value < 100000)
    {
        int firstDigit = value / 10000;
        int secondDigit = value / 1000 % 10;
        int fourthDigit = value / 10 % 10;
        int fifthDigit = value % 10;

        if (fifthDigit == fifthDigit && secondDigit == fourthDigit)
        {
            System.Console.WriteLine("Да");
        }
        else
        {
            System.Console.WriteLine("Нет");
        }
    }
    else
    {
        System.Console.WriteLine("Вы ввели не пятизначное число");
    }
}

int userNum = Prompt("Введите пятизначное число > ");
PalindromeFiveDigit(userNum);
