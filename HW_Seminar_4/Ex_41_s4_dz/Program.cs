// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber()
{
  Console.WriteLine("Enter a number: ");
  int ResNum = Convert.ToInt32(Console.ReadLine());
  return (ResNum);
}

int FuncExponentiation(int a, int b)
{
  int result;
  if (a == 0 && b == 0)
    result = 1;
  else
  {
    result = a;
    for (int i = 1; i < b; i++)
    {
      result = result * a;
    }
  }
  return (result);
}

void PrintStr(string str)
{
  Console.WriteLine($"{str}");
}

int num1, num2;
PrintStr($"Число {num1 = GetNumber()} в степени {num2 = GetNumber()} равно {FuncExponentiation(num1, num2)}");