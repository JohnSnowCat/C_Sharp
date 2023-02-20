/* Task 8 Homework Seminar_1:
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

class program
{
  static void Main(string[] args)
  {
    Console.Clear();
    Console.WriteLine("Enter a number:");
    int num = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    while (i <= num)
    {
      if (i % 2 == 0)
        Console.Write(i + " ");
      i++;
    }
  }
}