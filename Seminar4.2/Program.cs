// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.Clear();

int SetNumber(string text = "")
{
  Console.Write($"Enter number {text}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int MethodNum(int number)
{
  int count = 0;
  for (; number > 0; number /=10)
  {
    ++count;
  }
  return count;
}

int number = SetNumber();
//int i = 0;
//for (; num > 0; i++)
//{
 //num = num / 10;
//}
//System.Console.WriteLine($"{i}");



System.Console.WriteLine(MethodNum(number));