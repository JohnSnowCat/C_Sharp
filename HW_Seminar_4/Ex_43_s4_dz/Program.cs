// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] MakeArray(int len)
{
  int[] array = new int[len];
  return(array);
}

int[] FillArray(int[] arr, int len)
{
  for(int i = 0; i < len; i++)
    arr[i] = new Random().Next(-100, 101); // ???
  return(arr);
}

void PrintArray(int[] Array)
{
  Console.WriteLine($"[{string.Join(", ", Array)}]");
}

Console.Write("Enter a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
PrintArray(FillArray(MakeArray(size), size));


  