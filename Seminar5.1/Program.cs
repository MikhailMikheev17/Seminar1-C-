//Задача 31: Задайте массив из 12 элементов, заполненный случайными 
//числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.

Console.Clear();

int[] FillArray(int length, int minValue, int maxValue)
{
  int[] result = new int[length];
  Random rand = new Random();
  for (int i = 0; i < length; i++)
    result[i] = rand.Next(minValue, maxValue + 1);
  return result;
}

(int negative, int positive) GetSum(int[] array)
{
  int negative = 0;
  int positive = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
      positive += array[i];
    else
      negative += array[i];
  return (negative, positive);
}

int[] array = FillArray(12, -9, 9);
(int negative, int positive) = GetSum(array);

System.Console.WriteLine(string.Join(", ",array));
System.Console.WriteLine($"negativeSum = {negative}; positiveSum = {positive}");