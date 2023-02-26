// Задача 28: Напишите программу, которая принимает на вход число M и N и выдаёт произведение чисел от M до N.
// 2,4 -> 24 
// 1,5 -> 120

int MultiplyingNumbers(int a, int b)
{
  if (a == 0 || b == 0)
    return (0);
  else if (a > b)
    return (-1);
  int res = 1;
  while (a <= b)
  {
    res = res * a;
    a++;
  }
  return (res);
}

int num1 = 4;
int num2 = -2;
if ((MultiplyingNumbers(num1, num2)) == -1)
{
  int temp = num1;
  num1 = num2;
  num2 = temp;
  Console.WriteLine($"Произведение последовательности чисел от {num1} до {num2} = {MultiplyingNumbers(num1, num2)}");
}
else
  Console.WriteLine($"Произведение последовательности чисел от {num1} до {num2} = {MultiplyingNumbers(num1, num2)}");

