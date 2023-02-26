//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int GetSequenceSum(int num)
{
  int res = 0;
  for (int i = 1; i <= num; i++)
  {
    res = res + i;
  }
  return (res);
}

Console.WriteLine("Enter a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int result = GetSequenceSum(num1);
Console.WriteLine($"Sequence from 1 to {num1} -> {result}");