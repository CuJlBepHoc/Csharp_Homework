// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNaturalNumbers(int n)
{
    if (n <= 0)
    {
        Console.WriteLine();
    }
    else
    {
        if (n != 1)
        {
            Console.Write($"{n}, ");
        }
        else
        {
            Console.Write($"{n}");
        }
        PrintNaturalNumbers(n - 1);
    }
}

Console.Write("Enter value N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(N);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int CalculateSum(int m, int n)
{
    if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }
    if (m == n)
    {
        return m;
    }
    else
    {
        return n + CalculateSum(m, n - 1);
    }
}

Console.Write("Enter value M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter value N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = CalculateSum(M, N);
Console.WriteLine($"Sum of natural numbers from {M} to {N}: {sum}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

Console.Write("Enter value  m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter value  n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermannFunction(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");