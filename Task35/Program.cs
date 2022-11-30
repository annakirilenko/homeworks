// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [ 10, 11, 12, 13, 14 ] -> 5

void FillArrRandom(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0,1000);
    }
}
void PrintArr(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ",");
    }
    Console.Write("]");
    Console.WriteLine();
}
int size = 123;
int[] numbers = new int[size];
FillArrRandom(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArr(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] > 9 && numbers[z] < 100)
count++;

Console.WriteLine($"Всего 123 числа, {count} из них лежат в отрезке [10,99]");

