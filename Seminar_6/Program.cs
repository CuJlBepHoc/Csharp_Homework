// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Сделать оптимальное решение с наименьшим кол-вом строк.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] ReadArrayFromInput()
{
    Console.Write("Enter array size: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[m];

    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Enter {i + 1} array element");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int AboveZero(int[] array, int count = 0)
{
    for (int i = 0; i < array.Length; i++) { if (array[i] > 0) count++; }
    return count;
}

int[] array = ReadArrayFromInput();
Console.WriteLine($"Numbers greater than zero: {AboveZero(array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CalculateIntersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Intersection point: ({x}, {y})");
}


Console.WriteLine("Entar the k1 number");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entar the b1 number");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entar the k2 number");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entar the b2 number");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
    Console.WriteLine("The lines are parallel and have no points of intersection.");
else
    CalculateIntersection(k1, b1, k2, b2);



// Нужно найти 2 максимальных элемента произвольного массива.

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

void MaxValues(int[] array)
{
    int max1 = array[0];
    int max2 = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max2 = max1;
            max1 = array[i];
        }
        else if (array[i] > max2 && array[i] != max1)
        {
            max2 = array[i];
        }
    }
    Console.WriteLine($"Maximum array numbers is {max1} and {max2}");
}

Console.WriteLine("Enter min of array val:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max of array val:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(min, max, size);
ShowArray(newArray);
MaxValues(newArray);

