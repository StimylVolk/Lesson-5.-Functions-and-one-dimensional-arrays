// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, -100, 100);
int b = 0;

PrintArray(array);
Console.WriteLine();
SumOddPositions(array);

int ReadInt(string argument)
{
    Console.WriteLine($"Input {argument}:");
    return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);

    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void SumOddPositions(int[] array)
{

    for (int i = 1; i < array.Length; i += 2)
    {
        b = b + array[i];
    }
    Console.Write($"Sum Odd Positions: {b}");
}