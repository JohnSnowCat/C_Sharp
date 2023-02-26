//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа  
//78 -> 8

int GetRandom(int min, int max)
{
  return (new Random().Next(min, max));
}

int FindMaxNum(int num)
{
  int dig1 = num / 10;
  int dig2 = num % 10;
  if (dig1 > dig2)
    return (dig1);
  else
    return (dig2);
}

int num1 = GetRandom(10, 100);
int num2 = FindMaxNum(num1);
Console.WriteLine($"The random number is {num1} \nThe Max digit of number is {num2}"); //Console.WriteLine($"{FindMaxNum(GetRandom(10, 100))}");