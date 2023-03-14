// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Вывод:
// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

Console.Write("Введите кол-во строк в двумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов в двумерном массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] arrayOfNums = FillArray(rows, columns);
PrintArray(arrayOfNums);

int[] inputIndex = GetIndexForArray();
bool check = IndexValidator(inputIndex, arrayOfNums);

if (IndexValidator(inputIndex, arrayOfNums))
{
  Console.WriteLine($"[{string.Join(", ", inputIndex)}] -> {GetValueByIndex(arrayOfNums, inputIndex[0], inputIndex[1])}");
}
else
  Console.WriteLine($"Элемента с индексами [{string.Join(", ", inputIndex)}] в массиве нет");

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

int[] GetIndexForArray()
{
  int[] index = new int[2];
  Console.Write("Введиде индекс \"i\" интересующего элемента двумерного массива: ");
  index[0] = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введиде индекс \"j\" интересующего элемента двумерного массива: ");
  index[1] = Convert.ToInt32(Console.ReadLine());
  return index;
}

bool IndexValidator(int[] checkArray1D, double[,] checkArray2D)
{
  if ((checkArray1D[0] >= 0 && checkArray1D[0] < checkArray2D.GetLength(0)) && (checkArray1D[1] >= 0 && checkArray1D[1] < checkArray2D.GetLength(1)))
    return true;
  else
    return false;
}

double GetValueByIndex(double[,] inArray, int indexI, int indexJ)
{
  return inArray[indexI, indexJ];
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