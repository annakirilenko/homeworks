// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string array = Convert.ToString(number);

if (array.Length > 2)
{
  Console.WriteLine($"третья цифра - {array[2]}");
}
else
{
  Console.WriteLine("третьей цифры нет");
}