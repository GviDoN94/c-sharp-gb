// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int userNum = Prompt("Введите трехзначное число > ");

if (userNum > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(userNum / 10 % 10);
}
