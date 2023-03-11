// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] test = {{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4}};
PrintArray(test);
double[] res = GetAveregeColumns(test);
Console.WriteLine($" {string.Join("; ", res)}");

Console.Write("enter the number of rows of the array ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the number of columns of the array ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newTestArray = MakeArray(rows, columns);
PrintArray(newTestArray);
Console.WriteLine($"{string.Join(", ", GetAveregeColumns(newTestArray))}");

int[,] MakeArray(int m, int n)
{
  int[,] resultArray = new int[m,n];
  Random rnd = new Random();
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      resultArray[i, j] = rnd.Next(-100, 100);
    }
  }
  return resultArray;
}

double[] GetAveregeColumns(int[,] inputArray)
{
  double[] result = new double[inputArray.GetLength(1)];
  for(int j = 0; j < inputArray.GetLength(1); j++)
  {
      double sum = 0;
      for(int i = 0; i < inputArray.GetLength(0); i++)
      {
        sum = sum + inputArray[i,j];
      }
      result[j] = Math.Round((sum / inputArray.GetLength(0)), 2); 
  }
  return result;
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