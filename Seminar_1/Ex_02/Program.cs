// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

internal class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter a number");
    int num = Convert.ToInt32(Console.ReadLine());

    switch (num)
    {
      case 1:
        Console.WriteLine("1 -> Monday");
        break;
      case 2:
        Console.WriteLine("2 -> Tuesday");
        break;
      case 3:
        Console.WriteLine("3 -> Wednesday");
        break;
      case 4:
        Console.WriteLine("4 -> Thursday");
        break;
      case 5:
        Console.WriteLine("5 -> Friday");
        break;
      case 6:
        Console.WriteLine("6 -> Saturday");
        break;
      case 7:
        Console.WriteLine("7 -> Sunday");
        break;
      default:
        Console.WriteLine("There is no such day of the week on earth");
        break;
    }
  }
}