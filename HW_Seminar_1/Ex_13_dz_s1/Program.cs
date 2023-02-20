/* Task 6 Homework Seminar_1:
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

class program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter a number: ");
    int num = Int32.Parse(Console.ReadLine());
    if (num % 2 == 0)
      Console.WriteLine("Entered number is even");
    else
      Console.WriteLine("Entered number is odd");
  }
}