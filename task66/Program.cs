// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int m = GetPositivUserNumber("Введите начальное значение M: ", "Ошибка ввода");
int n = GetPositivUserNumber("Введите конечное значение N: ", "Ошибка ввода");

if (n > m)
{
    int result = GetSumNumber(m, n);
    Console.WriteLine($" M = {m}; N = {n} -> {result}");
}
else
{
    Console.WriteLine("Должен быть задан промежуток, введите корректное значение N ");
}

int GetSumNumber(int m, int n)
{
    if (m > n) return 0;
    else return m + GetSumNumber(m + 1, n);
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