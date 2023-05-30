// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int m = GetPositivUserNumber("Введите число M: ", "Ошибка ввода");
int n = GetPositivUserNumber("Введите число N: ", "Ошибка ввода");

int result = FuncAkkerman(m, n);
Console.WriteLine($" M = {m}; N = {n} -> A({m},{n}) = {result}");

int FuncAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) return FuncAkkerman(m - 1, 1);
    return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
}

int GetPositivUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber >= 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}