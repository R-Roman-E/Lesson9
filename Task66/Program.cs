﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n<=m)
    {
        Console.Write($"Сумма элементов {summ} ");
        return;
    }
    PrintSumm(m, n-1, summ);
}

int userNumberM = GetNumber("Введите число M:");
int userNumberN = GetNumber("Введите число N:");
PrintSumm(userNumberM, userNumberN, 0);