
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int FindTheSecondNumber(int num)
{
    if (num >= 100 && num < 1000)
    {
        Console.WriteLine(num / 10 % 10);
    }
    else
    {
        Console.WriteLine("Неверный ввод!");
    }
}
Console.Write("Введите трёх значное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int theSecondNumber = FindTheSecondNumber(n);
*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Введите любое число: ");
{
    {
        int num = Convert.ToInt32(Console.ReadLine());
        string numStr = Convert.ToString(num);
        int numDigit = numStr.Length;
        if (numDigit > 2) Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
        else Console.WriteLine("третьей цифры нет");
    }
}

// Проверка разряда числа.
int NumberDigit(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Введите число от 1 до 7:");
{
    int num = Convert.ToInt32(Console.ReadLine());

    if (num >= 1 && num <= 7)
    {
        if (num == 6 | num == 7) Console.WriteLine("Сегодня выходной");
        else Console.WriteLine("Сегодня рабочий день");
    }

    else Console.WriteLine("Не верное число");

}
*/
