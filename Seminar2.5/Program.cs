﻿//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

Console.Clear();

Console.WriteLine("Enter first number :");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number :");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == (num2*num2))
{
  Console.WriteLine("Является");
}
else if(num2 == (num1*num1))
{
Console.WriteLine("Является");
}
else Console.WriteLine("Не Является");