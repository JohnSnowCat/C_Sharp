// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = GetLenArray();
int[] arrnum = FillArray(MakeArray(size));
int result = GetSumOddElem(arrnum);
Console.WriteLine($"Сумма нечетных элементов массива {PrintArray(arrnum)} -> {result}");

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

int[] FillArray(int[] ar)
{
  Random rnd = new Random();
  for (int i = 0; i < ar.Length; i++)
    ar[i] = rnd.Next(-21, 21);
  return (ar);
}

int GetSumOddElem(int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i += 2)
    sum = sum + array[i];
  return (sum);
}

string PrintArray(int[] array)
{
  return ($"[{string.Join(", ", array)}]");
}