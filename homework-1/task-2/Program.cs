// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

using System;

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int userNum1 = Prompt("Введите первое число > ");
int userNum2 = Prompt("Введите второе число > ");
int userNum3 = Prompt("Введите третье число > ");
int maxNum = userNum1;

if (userNum2 > maxNum)
{
    maxNum = userNum2;
}
else if (userNum3 > maxNum)
{
    maxNum = userNum3;
}

Console.WriteLine(maxNum);
