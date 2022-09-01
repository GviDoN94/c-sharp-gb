// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool CheckUserNum(int userNum)
{
    return userNum >= 0;
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int argM = Prompt("Введите m аргумент функции > ");
int argN = Prompt("Введите n аргумент функции > ");

if (CheckUserNum(argM) && CheckUserNum(argN))
{
    System.Console.WriteLine(AckermannFunction(argM, argN));
}
else
{
    System.Console.WriteLine("Функция не принимает отрицательные аргументы");
}
