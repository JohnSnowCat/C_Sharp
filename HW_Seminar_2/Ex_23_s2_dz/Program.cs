/* Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

int num = new Random().Next(1, 8);
Console. WriteLine(num);
switch (num)
{
  case 1:
    Console.WriteLine("Нет, сегодня понедельник, а не выходной - бегом работать");
    break;
  case 2:
    Console.WriteLine("Нет, сегодня вторник, а не выходной - бегом работать");
    break;
  case 3:
    Console.WriteLine("Нет, сегодня среда, а не выходной - бегом работать");
    break;
  case 4:
    Console.WriteLine("Нет, сегодня четверг, а не выходной - бегом работать");
    break;
  case 5:
    Console.WriteLine("Нет, сегодня пятница, а не выходной - бегом работать");
    break;
  case 6:
    Console.WriteLine("Да, сегодня суббота, УРА!!!Выходной");
    break;
  case 7:
    Console.WriteLine("Да сегодня воскресенье, УРА!!!Выходной");
    break;
}