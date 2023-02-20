/* Task 4 Homework Seminar_1:
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter number1:");
    int num1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Enter number2:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number3:");
    int num3 = Int32.Parse(Console.ReadLine());
    if (num1 >= num2 && num1 >= num3)
      Console.WriteLine("Max number: " + num1);
    else if (num2 >= num1 && num2 >= num3)
      Console.WriteLine("Max number: " + num2);
    else
      Console.WriteLine("Max number: " + num3);
  }
}
