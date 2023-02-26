// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double GetRangeCord (int x1, int y1, int x2, int y2)
{
    double xpow = Math.Pow(Convert.ToDouble(x1 - x2), 2);
    double ypow = Math.Pow(Convert.ToDouble(y1 - y2), 2);
    double xysqrt = Math.Sqrt(xpow + ypow);
    return Math.Round(xysqrt, 2, MidpointRounding.ToZero);
}
Console.WriteLine($"Расстояние между точками {GetRangeCord(3, 6, 2, 1)}");
Console.WriteLine($"Расстояние между точками {GetRangeCord(7, -5, 1, -1)}");