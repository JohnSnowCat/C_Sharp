//Напишите программу которая выводит квадрат введенного числа.

Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());  //int num = Int32.Parse(Console.ReadLine());
Console.WriteLine("The square of the number is: " + Math.Pow(num, 2)); // num*num;