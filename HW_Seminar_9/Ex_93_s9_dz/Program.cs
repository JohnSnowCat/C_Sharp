﻿// Задача 68: Задайте значения M и N. 
// Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

(int, int) inData = Input();
Console.WriteLine($"{GetGreatestCommonDivisor(inData.Item1, inData.Item2)}");

(int, int) Input()
{
  Console.Write("Введите М: ");
  int m = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите N: ");
  int n = Convert.ToInt32(Console.ReadLine());
  return (m, n);
}

int GetGreatestCommonDivisor(int m, int n)
{
  if (m == 0 || n == 0)
    return (m + n);
  if (m > n)
    return GetGreatestCommonDivisor(m % n, n);
  else
    return GetGreatestCommonDivisor(m, n % m);
}

// int GetGreatestCommonDivisor(int m, int n)
// {
//   if (m == 0 || n == 0)
//     return m + n;
//   if (m > n)
//     return GetGreatestCommonDivisor(m - n, n);
//   else
//     return GetGreatestCommonDivisor(m, n - m);
// }