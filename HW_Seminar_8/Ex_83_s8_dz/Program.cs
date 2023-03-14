// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstMatrix = { { 2, 4 }, { 3, 2 } };
int[,] secondMatrx = { { 3, 4 }, { 3, 3 } };

int[,] res = GetMatrixMultiplication(firstMatrix, secondMatrx);
Console.WriteLine($"Результирующая матрица: ");
PrintArray(res);

int[,] GetMatrixMultiplication(int[,] fMatrix, int[,] sMatrix)
{
  int[,] error = new int[0, 0];
  if (fMatrix.GetLength(1) != sMatrix.GetLength(0))
  {
    Console.WriteLine("Перемножение не возможно! Введите правильную размерность матриц");
    return error;
  }

  int[,] resultMatrix = new int[fMatrix.GetLength(0), sMatrix.GetLength(1)];
  for (int i = 0; i < fMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < sMatrix.GetLength(1); j++)
    {
      for (int k = 0; k < fMatrix.GetLength(1); k++)
      {
        resultMatrix[i, j] = resultMatrix[i, j] + fMatrix[i, k] * sMatrix[k, j];
      }
    }
  }
  return resultMatrix;
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