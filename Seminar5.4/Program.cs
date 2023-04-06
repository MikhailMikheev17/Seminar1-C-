//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

Console.Clear();

int[] FillArray(int length, int minValue, int maxValue)
{
  int[] result = new int[length];
  Random rand = new Random();
  for (int i = 0; i < length; i++)
    result[i] = rand.Next(minValue, maxValue + 1);
  return result;
}

int[] GetNewArray(int[] array)
{
  int[] mult = new int[array.Length / 2];

  for (int i = 0; i < mult.Length; i++)
    {
      mult[i] = array[i] * array[array.Length - 1 - i];
    }
  return mult;
}

int[] array = FillArray(4, 1, 8);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(string.Join(", ", GetNewArray(array)));
