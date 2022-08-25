// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool CheckPositiveUserNum(int num)
{
    if (num > 0)
    {
        return true;
    }
    return false;
}

int count = 0;
while (true)
{
    if (CheckPositiveUserNum(Prompt("Введите число > ")))
    {
        count++;
    }
    System.Console.WriteLine($"Введено положительных чисел: {count}");
    System.Console.WriteLine($"Для завершения нажмите: CTRL+C");
}
