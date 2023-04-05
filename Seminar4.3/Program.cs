// от 1 до N умножение 

Console.Clear();

int SetNumber(string text = "")
{
  Console.Write($"Enter number {text}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int MethodMultiplication( int number)
{
  int i = 1;
  int multi = 1;
  for (;i<=number;i++)
  {
    multi = multi * i;
  }
  return multi;
  //System.Console.WriteLine($" multiplication = {multi}");
}

int num = SetNumber();

int multip = MethodMultiplication(num);
System.Console.WriteLine($"multiplication = {multip}");

