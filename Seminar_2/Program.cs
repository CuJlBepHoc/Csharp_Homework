// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

void SecondDigit(int num)
{
    if (num > -1000 && num < -99)
    {
        num = -num;
        int secondDigit = num / 10 % 10;
        Console.WriteLine($"Second digit of the number {secondDigit}");
    }
    else if (num > 99 && num < 1000)
    {
        int secondDigit = num / 10 % 10;
        Console.WriteLine($"Second digit of the number {secondDigit}");
    }
    else
    {
        Console.WriteLine("The entered number is not three digits.");
    }

}

Console.WriteLine("Enter the number: ");
int res = Convert.ToInt32(Console.ReadLine());
SecondDigit(res);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

void GetThirdDigit(int num)
{
    int absNum = num;
    if (num < 0)
    {
        absNum = -num;
    }

    int result = absNum;
    if (absNum > 99)
    {
        while (result > 999)
        {
            result /= 10;
        }
        result = result % 10;
        Console.WriteLine($"The third digit of {num} is {result}");
    }
    else
    {
        Console.WriteLine($"There is no third digit: {num}");
    }
}

Console.WriteLine("Enter the number: ");
int res = Convert.ToInt32(Console.ReadLine());
GetThirdDigit(res);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

string CheckDay(int day)
{
    if (day == 6 || day == 7)
    {
        return "Day off";
    }
    else if (day > 0 && day < 6)
    {
        return "Weekday";
    }
    else
    {
        return "On our planet 7 days a week";
    }
}

Console.WriteLine("Enter the number of day: ");
int day = Convert.ToInt32(Console.ReadLine());
string answer = CheckDay(day);
Console.WriteLine(answer);
