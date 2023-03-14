// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

(int, int) incomingArraySize = Input();
int[,] array = FillArray(incomingArraySize.Item1, incomingArraySize.Item2);

PrintArray(array);

int[] sumInRows = GetSumInRows(array);
Console.WriteLine($"[{string.Join(", ", sumInRows)}]");
Console.WriteLine($"Номер строки  массива с наименьшей суммой -> {GetNumberRowByMinSum(sumInRows) + 1}");

(int, int) Input()
{
  Console.Write("Введите кол-во строк в двумерном массиве: ");
  int rows = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите кол-во столбцов в двумерном массиве: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  if (rows == columns)
  {
    Console.WriteLine("Введите прямоугольный массив!");
    return Input();
  }
  return (rows, columns);
}

int[,] FillArray(int rows, int columns)
{
  int[,] resultArray = new int[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      resultArray[i, j] = GetRandomNumber(0, 11);
    }
  }
  return resultArray;
}

int GetRandomNumber(int min, int max)
{
  Random rnd = new Random();
  return rnd.Next(min, max);
}

int[] GetSumInRows(int[,] inputArray)
{
  int[] SumByRows = new int[inputArray.GetLength(0)];
  for (int i = 0; i < inputArray.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
      sum = sum + inputArray[i, j];
    }
    SumByRows[i] = sum;
  }
  return SumByRows;
}

int GetNumberRowByMinSum(int[] SumByRowInArray)
{
  int indMin = 0;
  for (int i = 1; i < SumByRowInArray.Length; i++)
  {
    if (SumByRowInArray[indMin] > SumByRowInArray[i]) // 2 0 3 2
      indMin = i;
  }
  return indMin;
}

void PrintArray(int[,] inputArray)
{
  for (int i = 0; i < inputArray.GetLength(0); i++)
  {
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
      Console.Write(inputArray[i, j] + "\t");
    }
    Console.WriteLine();
  }
}