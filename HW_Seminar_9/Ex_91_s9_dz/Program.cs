// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

GetSequencyOfEvenNumbers(m, n);

void GetSequencyOfEvenNumbers(int a, int b)
{
  if (a <= b)
  {
    if (a % 2 == 0)
    {
      Console.Write($"{a} ");
      GetSequencyOfEvenNumbers(a + 2, b);
    }
    else
    {
      Console.Write($"{++a} ");
      GetSequencyOfEvenNumbers(a + 2, b);
    }
  }
}