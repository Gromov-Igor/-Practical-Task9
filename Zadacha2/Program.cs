// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсия!

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumInRange(int m, int n)
{
    if (m > n)
    {
        return 0;
    }

    return GetSumInRange(m + 1, n) + m;
}

int start = Prompt("Write down start:");
int end = Prompt("Write down end:");

int sum = GetSumInRange(start, end);
Console.WriteLine($"M = {start}, N = {end} -> {sum}");