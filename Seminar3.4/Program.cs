// Напишите программу, которая принимает на вход координаты двух точек и находит
//расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.Clear();

System.Console.WriteLine("Enter first coordinate :");
int numX1 = int.Parse(Console.ReadLine());
int numX2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter second coordinate :");
int numY1 = int.Parse(Console.ReadLine());
int numY2 = int.Parse(Console.ReadLine());

double S = Math.Pow((Math.Pow(numY1-numX1,2) + Math.Pow(numX2 - numY2,2)), 0.5);
double sk = Math.Sqrt((numY1-numX1)*(numY1-numX1) + (numX2 - numY2)*(numX2 - numY2) );//2 вариант 


System.Console.WriteLine($"S = {S}");
System.Console.WriteLine($"{sk}");

