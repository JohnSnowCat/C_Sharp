// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите кол-во строк в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArray(rows, columns);
PrintArray(array);

double GetRandomNumber(int min, int max)
{
  Random rnd = new Random();
  return Math.Round(rnd.Next(min, max) * rnd.NextDouble(), 1);
}

double[,] FillArray(int rows, int columns)
{
  double[,] resultArray = new double[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      resultArray[i, j] = GetRandomNumber(-100, 101);
    }
  }
  return resultArray;
}

void PrintArray(double[,] inputArray)
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