//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.WriteLine("Enter first number:");
//int num1 = int.Parse(Console.ReadLine());
string numFirst = Console.ReadLine();
int num1 = Convert.ToInt32(numFirst);


Console.WriteLine("Enter second number:");
//int num2 = int.Parse(Console.ReadLine());
string numSecond= Console.ReadLine();
int num2 = Convert.ToInt32(numSecond);


int check = (num2 * num2);

if (check == num1)
{
  Console.WriteLine("Является");
}
else
{
  Console.WriteLine("Нe Является");
}




