int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int userNum1 = Prompt("Введите первое число > ");
int userNum2 = Prompt("Введите второе число > ");

if (userNum1 > userNum2) {
    System.Console.WriteLine($"Число {userNum1} больше числа {userNum2}");
} else if (userNum1 < userNum2) {
    System.Console.WriteLine($"Число {userNum1} меньше числа {userNum2}");
} else if (userNum1 == userNum2) {
    System.Console.WriteLine($"Число {userNum1} равно числу {userNum2}");
}
