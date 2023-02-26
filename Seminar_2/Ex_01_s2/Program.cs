// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// Пример, 456 -> 46 782 -> 72 918 -> 98

int GetRandom(int min, int max)
{
  return (new Random().Next(min, max));
}

int GetModifNumber(int num)
{
  return (num / 100 * 10 + num % 10);
}

int result = GetRandom(100, 1000);
Console.WriteLine($"The original number is {result}\nThe modifed number is {GetModifNumber(result)}");