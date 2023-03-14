// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] testArray = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

int[,] result = SortArray(testArray);
PrintArray(result);

int[,] SortArray(int[,] inArr)
{
  for (int i = 0; i < testArray.GetLength(0); i++)
  {
    for (int j = 0; j < testArray.GetLength(1); j++)
    {
      for (int k = j + 1; k < testArray.GetLength(1); k++)
      {
        if (inArr[i, j] < inArr[i, k])
        {
          int temp = inArr[i, j];
          inArr[i, j] = inArr[i, k];
          inArr[i, k] = temp;
        }
      }
    }
  }
  return inArr;
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