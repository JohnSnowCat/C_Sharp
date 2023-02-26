// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.  
// 5, 25   ->  да 
// -4, 16  ->  да 
// 25, 5   ->  да 
// 8, 9     ->  нет

Console.WriteLine("Enter a number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool FunCheck(int a, int b)
{
  if ( Math.Pow(a, 2) == b || Math.Pow(b, 2) == a)
    return(true);
  else
    return(false);
}
bool res = FunCheck(num1, num2);

Console.WriteLine($"{res}");