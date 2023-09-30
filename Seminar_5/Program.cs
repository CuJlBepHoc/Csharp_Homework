// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateThreeDigitArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i > 0)
        {
            Console.Write(" ");
        }
        Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int Positive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;

    }
    return count;
}


Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateThreeDigitArray(size);
ShowArray(array);
int even = Positive(array);
Console.WriteLine($"Even numbers in an array {even}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i > 0)
        {
            Console.Write(" ");
        }
        Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int SumOddIndex(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    return summ;
}

Console.WriteLine("Enter min of array val:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max of array val:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(min, max, size);
ShowArray(array);
int summ = SumOddIndex(array);
Console.WriteLine($"Even numbers in an array {summ}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
// Random.NextDouble() * (maxValue - minValue) + minValue


double[] CreateRandomArray(int min, int max, int size)
{
    Random rnd = new Random();
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void ShowArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i > 0)
        {
            Console.Write(" ");
        }
        Console.Write($"{array[i]:F2}");
    }
    Console.WriteLine("]");
}

void Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"The minimum value is {min:F2} and the maximum value {max:F2}");
}

Console.WriteLine("Enter min of array val:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max of array val:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomArray(min, max, size);
ShowArray(array);
Difference(array);
