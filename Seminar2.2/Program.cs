//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

Console.Clear();

int num = new Random().Next(100,1000);
Console.WriteLine($"рандомное число : {num}");

int numOne = num / 100;
int numTwo = num / 10;
int numThree = num % 10;
int result = numOne*10+numThree;
Console.WriteLine(result);

