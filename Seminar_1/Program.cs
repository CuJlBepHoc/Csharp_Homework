// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

/*
Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2){
    Console.WriteLine($"The first number is greater ({num1})");
} 
else if (num1 < num2){
    Console.WriteLine($"The second number is greater ({num2})");
} 
else{
    Console.WriteLine($"The numbers are equal");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
/*
Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2 && num1 >= num3){
    Console.WriteLine($"Maximum number: {num1}");
} 
else if (num2 >= num1 && num2 >= num3){
    Console.WriteLine($"Maximum number: {num2}");
} 
else{
    Console.WriteLine($"Maximum number: {num3}");
}
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
/*
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0){
    Console.WriteLine($"The number {num} is even");
}
else{
    Console.WriteLine($"The number {num} is an odd number.");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++){
    if (i % 2 == 0){
        Console.WriteLine(i);
    }
}
