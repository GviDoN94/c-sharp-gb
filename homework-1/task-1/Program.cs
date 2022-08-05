// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

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

if (userNum1 > userNum2) {
    Console.WriteLine($"max = {userNum1} min = {userNum2}");
} else if (userNum1 < userNum2) {
    Console.WriteLine($"max = {userNum2} min = {userNum1}");
} else if (userNum1 == userNum2) {
    Console.WriteLine($"{userNum1} = {userNum2}");
}
