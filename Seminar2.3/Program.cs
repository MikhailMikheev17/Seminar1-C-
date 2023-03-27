// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно
Console.Clear();

Console.WriteLine(" Enter first number : ");
string strNum = Console.ReadLine();
int num1 = Convert.ToInt32(strNum);

Console.WriteLine(" Enter second number : ");
string strNum1 = Console.ReadLine();
int num2 = Convert.ToInt32(strNum1);

int crat = num1 % num2;

if (crat == 0)
{
  Console.Write(" Кратно");
}
else
{
  Console.Write($"Некратно и остаток {crat}");
}