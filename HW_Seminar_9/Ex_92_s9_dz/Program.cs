// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

(int, int) Input()
{
  Console.Write("Введите М: ");
  int m = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите N: ");
  int n = Convert.ToInt32(Console.ReadLine());
  if (m < 0 || n < 0 || m > n)
  {
    Console.WriteLine("Введите интервал из натуральных чисел");
    return Input(); //вопрос по возврату в случае ошибки!?
  }
  return (m, n);
}

int GetSumBySequency(int a, int b)
{

  int sum = a;
  if (a < b)
  {
    sum = sum + GetSumBySequency(a + 1, b);
  }
  return sum;
}

(int, int) pointOfSequency = Input();
int result = GetSumBySequency(pointOfSequency.Item1, pointOfSequency.Item2);
Console.WriteLine("Сумма натуральных чисел от {0} до {1} -> {2}", pointOfSequency.Item1, pointOfSequency.Item2, result);