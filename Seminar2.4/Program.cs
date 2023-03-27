// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
//7 и 23.

//14 -> нет 
//46 -> нет 
//161 -> да

Console.Clear();
Console.WriteLine(" Enter number : ");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);


if (num%7 ==0 && num%23 ==0)
{
  Console.WriteLine("кратно и 23  и 7");
}
else 
{
  Console.WriteLine("не кратно");
}

//Console.Clear();
//Console.Write("Введите A: ");
//int numberA = Convert.ToInt32(Console.ReadLine());

//if (numberA % 7 == 0 & numberA % 23 == 0)
//{
//  Console.Write($"Кратно");
//}
//else 
//{
//     Console.Write($"не кратно ");
//}