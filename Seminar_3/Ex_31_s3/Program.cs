/*
Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат 
точек в этой четверти (x и y).
*/

int GetRandPositivNumber()
{
    return new Random().Next(0, 1000);
}
int GetRandNegativNumber()
{
    return new Random().Next(-1000, 0);
}
Console.Write("Введите четверть: ");
int area = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
switch (area)
{
    case 1:
        Console.WriteLine($" X : {GetRandPositivNumber()} Y : {GetRandPositivNumber()}");
        break;
    case 2:
        Console.WriteLine($" X : {GetRandPositivNumber()} Y : {GetRandNegativNumber()}");
        break;
    case 3:
        Console.WriteLine($" X : {GetRandNegativNumber()} Y : {GetRandNegativNumber()}");
        break;
    case 4:
        Console.WriteLine($" X -: {GetRandNegativNumber()} Y : {GetRandPositivNumber()}");
        break;
}