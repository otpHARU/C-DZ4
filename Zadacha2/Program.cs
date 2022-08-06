﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int result = 0;

while (numberN > 0)
{
    result += numberN % 10;
    numberN /= 10;
}

Console.WriteLine("Сумма цифр в числе = " + result);











