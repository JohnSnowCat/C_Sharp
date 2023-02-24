//=====Задача 23=====
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
  int res = i * i * i;
  if (i != num)
    Console.Write($"{res}, ");
  else
    Console.Write($"{res} ");
}
if (num == 0)
  Console.WriteLine(0);
