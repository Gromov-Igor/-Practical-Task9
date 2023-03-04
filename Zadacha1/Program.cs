// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }

    if (m % 2 == 0)
    {
        Console.Write($"{m} ");
    }

    ShowNumbers(m + 1, n);
}

int start = Prompt("Write down start:");
int end = Prompt("Write down end:");
Console.Write($"M = {start}, N = {end} -> ");
ShowNumbers(start, end);