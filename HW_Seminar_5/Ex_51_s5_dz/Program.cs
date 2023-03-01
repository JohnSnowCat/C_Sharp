// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = GetLenArray();
int[] ArrNUm = FillArray(MakeArray(size), size);
int result = EvenCounter(ArrNUm);
PrintArray(ArrNUm, result);

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
    ar[i] = rnd.Next(100, 1000);
  return (ar);
}

int EvenCounter(int[] Array)
{
  int count = 0;
  foreach (int element in Array) //   for (int i = 0; i < size; i++) if (Array[i] % 2 == 0) count++;
    count += element % 2 == 0 ? 1 : 0;
  return (count);
}

void PrintArray(int[] Array, int res)
{
  Console.WriteLine($"[{string.Join(", ", Array)}] -> {res}");
}