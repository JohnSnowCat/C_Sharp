// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = GetLenArray();
double[] ArrNum = FillArray(MakeArray(size), size);
double result = GetDifResult(GetMaxElem(ArrNum), GetMinElem(ArrNum));
Console.WriteLine($"{PrintResult(ArrNum, result)}");

int GetLenArray()
{
  Console.Write("Enter a length of array: ");
  return (Convert.ToInt32(Console.ReadLine()));
}

double[] MakeArray(int len)
{
  double[] array = new double[len];
  return (array);
}

double[] FillArray(double[] ar, int len)
{
  Random rnd = new Random();
  for (int i = 0; i < len; i++)
    ar[i] = Math.Round(rnd.Next(-10, 11) * rnd.NextDouble(), 1);
  return (ar);
}

double GetMaxElem(double[] array)
{
  double max = array[0];
  for (int i = 1; i < array.Length; i++)
    if (array[i] > max) max = array[i];
  return max;
}

double GetMinElem(double[] array)
{
  double min = array[0];
  for (int i = 1; i < array.Length; i++)
    if (array[i] < min) min = array[i];
  return min;
}
double GetDifResult(double max, double min)
{
  return max - min;
}

string PrintResult(double[] Array, double res)
{
  return ($"Разница между максимальным и минимальным элементами массива [{string.Join(", ", Array)}] -> {res}");
}