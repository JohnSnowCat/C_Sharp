Console.Clear();
//Console.SetCursorPosition(4, 2);
//Console.WriteLine("-");

int xa = 40, ya = 1,
    xb = 1,  yb = 30,
    xc = 80, yc = 30;

int x = xa;
int y = xb;

int count = 0;

while (count < 45)
{
  int rm = new Random().Next(0, 3);
  if (rm == 0)
  {
    x = (x + xa) / 2;
    y = (y + ya) / 2;
  }
  if (rm == 1)
  {
    x = (x + xb) / 2;
    y = (y + yb) / 2;
  }
  if (rm == 2)
  {
    x = (x + xc) / 2;
    y = (y + yc) / 2;
  }
  Console.SetCursorPosition(x, y);
  Console.WriteLine("+");
  count++;
}
/*Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
if (xa == xb)
{
  int avg = (ya + yb) / 2;
  Console.SetCursorPosition(xb, avg);
  Console.WriteLine("+");
}
else
{
  int avg = (xa + xb) / 2;
  Console.SetCursorPosition(avg, ya);
  Console.WriteLine("+");
}

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
*/