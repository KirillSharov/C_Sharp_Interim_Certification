// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetweenNum(int M, int N)
{
    int sum = 0;
    if (M < N) return sum += M + SumBetweenNum(M + 1, N);
    else return sum += M;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int M = GetInfo("Введите число M: ");
int N = GetInfo("Введите число N: ");
Console.WriteLine($"M = {M}; N = {N} -> {SumBetweenNum(M, N)}");