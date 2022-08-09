// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int userNum = Prompt("Введите число > ");
Console.WriteLine(userNum);

if (userNum < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (userNum > 999)
    {
        userNum /= 10;
    }
    Console.WriteLine(userNum % 10);
}
