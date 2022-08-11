// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void CubeNumberList(int value)
{
    if (value > 0)
    {
        for (int i = 1; i <= value; i++)
        {
            int result = i * i * i;
            System.Console.Write(result + "\t");
        }
    }
    else
    {
        for (int i = -1; i >= value; i--)
        {
            int result = i * i * i;
            System.Console.Write(result + "\t");
        }
    }
}

int userNum = Prompt("Введите число > ");
CubeNumberList(userNum);
