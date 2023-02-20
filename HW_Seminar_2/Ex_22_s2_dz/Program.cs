/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


int num = new Random().Next(-2147483648, 2147483647);
Console.Write($"{num}\n");
if (num < 100 && num > -100)
{
  Console.WriteLine("3-й цифры нет");
}
else
{
  while (num > 100 || num < -100)
  {
    if ((num >= 100 && num <= 999) || (num <= -100 && num >= -999))
      Console.WriteLine(Math.Abs(num % 10));
    num = num / 10;
  }
}