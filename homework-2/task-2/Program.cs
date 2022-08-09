// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int randomNum = new Random().Next(100, 1000);
Console.WriteLine(randomNum);

int firstNum = randomNum / 100;
int thirdNum = randomNum % 10;
int result = firstNum * 10 + thirdNum;
Console.WriteLine(result);
