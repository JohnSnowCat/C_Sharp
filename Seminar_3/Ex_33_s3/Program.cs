// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

void WriteConsolePowTab (int value)
{
  Console.Write($"{value} -> ");
    for (int i = 1; i <= value; i++)
    {
        Console.Write($"{Math.Pow(i, 2)}");
        Console.Write(i == value ? "." : ", ");
    }
    Console.WriteLine("");
}
WriteConsolePowTab(5);
WriteConsolePowTab(2);
WriteConsolePowTab(10);
