// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

double X(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

double Y(double b1, double k1, double x)
{
    return k1 * x + b1;
}

double b1 = Prompt("Введите b1 > ");
double k1 = Prompt("Введите k1 > ");
double b2 = Prompt("Введите b2 > ");
double k2 = Prompt("Введите k2 > ");
double x = X(b1, k1, b2, k2);

System.Console.WriteLine($"Прямые пересекутся в точке ({x:f1}; {Y(b1, k1, x):f1})");
