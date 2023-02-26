// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет



Console.WriteLine("Enter a number one");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number two");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 == Math.Sqrt(num1) || num2 == -Math.Sqrt(num1))
{
  Console.WriteLine("Yes the second number is the first number squared");
}
else
  Console.WriteLine("No");

// #############################
// Console.WriteLine("Enter a number one");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a number two");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == Math.Pow(num2, 2))
// {
//   Console.WriteLine("Yes the second number is the first number squared");
// }
// else
//   Console.WriteLine("No second number is not the first number squared");