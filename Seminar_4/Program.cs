// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void Degree(int num1, int num2)
// {
//     int res = num1;
//     for (int i = 1; i < num2; i++)
//     {
//         res *= num1;

//     }
//     Console.WriteLine($"The number {num1} to the power of {num2} is equal to {res}");

// }

// Console.WriteLine("Enter first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number");
// int b = Convert.ToInt32(Console.ReadLine());

// Degree(a, b);

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12


// void SummNumber(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         int digit = num % 10;
//         num /= 10;
//         sum += digit;
//     }
//     Console.WriteLine($"Sum of digits = {sum}");
// }

// Console.WriteLine("Enter number");
// int num = Convert.ToInt32(Console.ReadLine());

// SummNumber(num);

// Задача 29: Напишите программу, которая задаёт массив из произвольных элементов и выводит их на экран.
// Размер массива рандом до 10, элементы до 101.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray()
{
    return new int[new Random().Next(0, 10)];
}

int[] FillingArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
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
    Console.Write("]");
}

ShowArray(FillingArray(CreateRandomArray()));