// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string GetNumber()
{
  Console.Write("Enter a number: ");
  string ResNum = Console.ReadLine();
  return (ResNum);
}

int GetSumDigitsByStr(string str)
{
  int sum = 0;
  if (str[0] == '-')
  {
    for (int i = 1; i < str.Length; i++)
    {
      sum = sum + (str[i] - '0');
    }
  }
  else
  {
    for (int i = 0; i < str.Length; i++)
    {
      sum = sum + (str[i] - '0');  //sum = sum + (Convert.ToInt32(str[i].ToString()));
    }
  }
  return (sum);
}
string number = GetNumber();

Console.WriteLine(number);

int value = GetSumDigitsByStr(number);
Console.WriteLine(value);

//############ Вариант 2 ##############
/*
int GetNumber()
{
  Console.Write("Enter a number: ");
  int ResNum = Convert.ToInt32(Console.ReadLine());
  return (ResNum);
}

int GetSumDigitsByNum(int number)
{
  int sum = 0;
  if (number == 0)
    return(0);
  else if (number < 0)
  {
    number *= -1;
  }
  while (number != 0)
  {
    sum = sum + number % 10;
    number = number / 10;
  }
  return(sum);
}

void PrintStr(string str)
{
  Console.WriteLine(str);
}

int NumIn = GetNumber();

PrintStr($"Сумма цифр числа {NumIn} -> {GetSumDigitsByNum(NumIn)}");
*/