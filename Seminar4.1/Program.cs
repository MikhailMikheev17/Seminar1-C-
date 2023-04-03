// Задача 24: Напишите программу, 
// которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
int SetNumber(string text = "")
{
  Console.Write($"Enter number {text}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int num = SetNumber();
int sum = 0;
for (int i = 1; i <= num; ++i)
{
  sum += i;
}
System.Console.WriteLine("sum = "+ sum);