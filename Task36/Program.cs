// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArrRandom(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(10,100);
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

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrRandom(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArr(numbers);

int sum = 0;
for (int z = 1; z < numbers.Length; z+=2)
sum = sum + numbers[z];

Console.WriteLine($"Всего {numbers.Length} чисел. Сумма чисел, стоящих на нечетных позициях - {sum}");