// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumberOfDigits(int num)
{
  int count = 0;
  if (num == 0)
    return (1);
  while (num != 0)
  {
    num = num / 10;
    count += 1;
  }
  return (count);
}

Console.WriteLine("Enter a number: ");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{value} -> {GetNumberOfDigits(value)}");
Console.WriteLine($"{value} -> {GetLengthOfNumber(value)}");


int GetLengthOfNumber(int num)
{
  string str = Convert.ToString(num);
  return (str.Length);
}
