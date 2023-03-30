//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

System.Console.Write(" Enter number of sectioin :");
int numSection = int.Parse(Console.ReadLine());

if (numSection == 1)
{
  System.Console.WriteLine(" x > 0, y > 0");
}
else if (numSection == 2)
{
  System.Console.WriteLine("x < 0, y > 0");
}
else if (numSection == 3)
{
  System.Console.WriteLine("x < 0 , y < 0");
}
else if (numSection == 4)
{
  System.Console.WriteLine(" x > 0 , y < 0");
}
else System.Console.WriteLine("No section");