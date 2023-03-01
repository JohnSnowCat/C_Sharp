// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = GetLenArray();
int[] ArrNUm = FillArray(MakeArray(size), size);
int result = GetSumOddElem(ArrNUm, size);
Console.WriteLine($"Сумма нечетных элементов массива {PrintArray(ArrNUm)} -> {result}");

int GetLenArray()
{
  Console.Write("Enter a length of array: ");
  return (Convert.ToInt32(Console.ReadLine()));
}

int[] MakeArray(int len)
{
  int[] array = new int[len];
  return (array);
}

int[] FillArray(int[] ar, int len)
{
  Random rnd = new Random();
  for (int i = 0; i < len; i++)
    ar[i] = rnd.Next(-21, 21);
  return (ar);
}

int GetSumOddElem(int[] Array, int len)
{
  int sum = 0;
  for (int i = 1; i < len; i += 2)
    sum = sum + Array[i];
  return (sum);
}

string PrintArray(int[] Array)
{
  return ($"[{string.Join(", ", Array)}]");
}