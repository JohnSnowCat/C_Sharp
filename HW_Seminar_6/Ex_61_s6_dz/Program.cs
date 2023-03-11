// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] Input()
{
  Console.Write("Укажите количество вводимых чисел: ");
  int n = Convert.ToInt32(Console.ReadLine());
  if (n <= 0)
  {
    Console.WriteLine("Вы ввели некорректное значение. Повторите ввод");
    return Input();
  }
  int i = 0;
  int[] array = new int[n];
  while (i < n)
  {
    Console.WriteLine($"Введите {i + 1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
  }
  return array;
}

int GetCountPositiveNumber(int[] source)
{
  int count = 0;
  for (int j = 0; j < source.Length; j++)
  {
    if (source[j] >= 0)
    {
      count++;
    }
  }
  return count;
}

int[] stringInput = Input();
Console.Write($"Вы ввели следующие числа: [{string.Join(" , ", stringInput)}]. ");
Console.Write($"Количество положительных чисел введенных Вами равно {GetCountPositiveNumber(stringInput)}");