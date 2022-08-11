// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void Сoordinates3D(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az));
    result = Math.Round(result, 2);
    System.Console.WriteLine(result);
}

int ax = Prompt("Введите x координиту первой точки > ");
int ay = Prompt("Введите y координиту первой точки > ");
int az = Prompt("Введите z координиту первой точки > ");
int bx = Prompt("Введите x координиту второй точки > ");
int by = Prompt("Введите y координиту второй точки > ");
int bz = Prompt("Введите z координиту второй точки > ");

Сoordinates3D(ax, ay, az, bx, by, bz);
