// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
int n = GetPositivUserNumber("Введите значение N: ", "Ошибка ввода");
int m = 1;

string result = PrintNaturalNumbers(n, m);

Console.WriteLine($"{n} -> {result}");

string PrintNaturalNumbers(int n, int m)
{
    if (n == m) return m.ToString();
    return n + " " + PrintNaturalNumbers(n-1, m);
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
