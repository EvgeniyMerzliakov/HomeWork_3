﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());

int x1 = x / 10000;
int x2 = x / 1000 % 10;
int x4 = x % 100 / 10;
int x5 = x % 10;

if (x1 == x5 && x2 == x4) Console.WriteLine("да");
else Console.WriteLine("нет");
