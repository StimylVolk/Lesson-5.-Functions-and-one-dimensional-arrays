// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int length = ReadInt("Array length");
double[] array = GetRandomArray(length, -10, 10);
double max = FindMax(array);
double min = FindMin(array);

PrintArray(array);
Console.WriteLine();
dif(max, min);

int ReadInt(string argument)
{
    Console.WriteLine($"Input {argument}:");
    return int.Parse(Console.ReadLine());
}

double[] GetRandomArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 2);

    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) { max = array[i]; }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; }
    }
    return min;
}

void dif(double max, double min)
{
    Console.WriteLine($"Difference between the maximum and minimum number = {max - min}");
}