// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int RandomDigit(int min, int max)
{
  return (new Random().Next(min, max + 1));
}

void FillArray(int[] Arr)
{
  for (int i = 0; i < Arr.Length; i++)
  {
    Arr[i] = RandomDigit(0, 1);
  }
}

void PrintArrNum(int[] Arr)
{
  foreach (int elem in Arr)
    Console.Write($"{elem} ");
  Console.WriteLine();
}

int[] Array = new int[8];
FillArray(Array);
PrintArrNum(Array);
Console.Write($"[{string.Join(", ", Array)}]");

