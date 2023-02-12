internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("Insert username");
    string username = Console.ReadLine();
    if (username.ToLower() == "john")
      Console.WriteLine("Hello my dear king John");
    else
    {
      Console.Write("Hello, ");
      Console.WriteLine(username);
    }
  }
}