// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8


Console.WriteLine("Enter a number");
int num1 = Convert.ToInt32(Console.ReadLine());
num1 = num1 % 10;
Console.WriteLine(num1);
