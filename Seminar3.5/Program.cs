//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.Clear();

System.Console.Write("Enter number N: ");
int numN = int.Parse(Console.ReadLine());

for (double i = 1; i <= numN;i++)
{
  double pow = Math.Pow(i,2);
  System.Console.Write($"{pow} ");
}

