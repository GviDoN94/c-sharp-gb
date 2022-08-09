// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int day = Prompt("Введите номер дня недели > ");

int[] week = { 0, 0, 0, 0, 0, 1, 1 };

if (day > 7)
{
    Console.WriteLine("Вы ввели не правильное число");
}
else
{
    if (week[day - 1] == 1)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
