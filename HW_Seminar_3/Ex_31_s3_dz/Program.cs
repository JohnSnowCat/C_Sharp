//=====Задача 19======
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res1 = num / 1000;
int res2 = num % 10 * 10 + num % 100 / 10;
if (res1 == res2)
  Console.WriteLine($"Entered number {num} is palindrome, YES!");
else
  Console.WriteLine($"Entered number {num} is NOT palindrome. NO!");
