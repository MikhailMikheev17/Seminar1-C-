// Задача40.Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.

Console.Clear();

System.Console.WriteLine(" enter  number  >  ");
int num  = int.Parse(Console.ReadLine());
System.Console.WriteLine(" enter base  >  ");
int @base  = int.Parse(Console.ReadLine());
System.Console.WriteLine(ChangeBase(num,@base));

string ChangeBase(int num, int @base)
{
  int[] array = new int[32];
  for (int i = 31; ; i--)
  {
    array[i] = num % @base;
    num /= @base;
    if (num == 0) break;
  }
  return String.Join("", array);
}




