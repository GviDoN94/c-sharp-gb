// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int Exponentiation(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result *= num1;
    }

    return result;
}

bool CheckUserNum(int userNum)
{
    return userNum > 0;
}

int userNum1 = Prompt("Введите число возводимое в степень > ");
int userNum2 = Prompt("Введите степень в которую нужно возвести число > ");

if (!CheckUserNum(userNum1) || !CheckUserNum(userNum2))
{
    System.Console.WriteLine("Нужно ввести положительное число");
}
else
{
    System.Console.WriteLine(Exponentiation(userNum1, userNum2));
}
