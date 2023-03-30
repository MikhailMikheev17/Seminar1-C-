//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();

System.Console.Write("Enter number x :");
int numX = int.Parse(Console.ReadLine());

System.Console.Write("Enter number y :");
int numY = int.Parse(Console.ReadLine());

if (numX > 0 && numY > 0)
{
  System.Console.WriteLine("Первая четверть");
}
else if( numX < 0 && numY > 0)
{
  System.Console.WriteLine("Вторая четверть ");
}
else if( numX < 0 && numY < 0)
{
  System.Console.WriteLine("Третья четверть ");
}
else 
{
  System.Console.WriteLine("Четвертая четверть ");
}

