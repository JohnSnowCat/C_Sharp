// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.  
// Например, 34, 5 -> не кратно, остаток 4  16, 4 -> кратно

int ReadIn()
{
  Console.WriteLine("Enter a number: ");
  int res = Convert.ToInt32(Console.ReadLine()); //Int32.TryParse(Console.ReadLine()); 
  return (res);
}

bool MultiplicityСheck(int a, int b)
{
  if (a % b == 0)
    return (true);
  else
    return (false);
}

int num1 = ReadIn();
int num2 = ReadIn();

if (MultiplicityСheck(num1, num2))
  Console.WriteLine($"{num2} is a multiple of {num1}");
else
  Console.WriteLine($"{num2} is NOT! a multiple of {num1}, remainder is {num1 % num2}");


