/* Task 2 Homework Seminar_1:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter number1:");
    int num1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Enter number2:");
    int num2 = Int32.Parse(Console.ReadLine());
    if (num1 > num2)
    {
      Console.WriteLine("Max number: " + num1);
      Console.WriteLine("Min number: " + num2);
    }
    else
    {
      Console.WriteLine("Max number: " + num2);
      Console.WriteLine("Min number: " + num1);
    }
  }
}