// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using System;

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int userNum = Prompt("Введите число > ");

if (userNum < 1)
{
    Console.WriteLine("Нужно ввести положительное число");
}

for (int i = 2; i <= userNum; i += 2)
{
    Console.WriteLine(i);
}
