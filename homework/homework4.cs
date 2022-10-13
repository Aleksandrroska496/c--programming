//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 11);
    Console.Write(" " + Method(i) + " ");
}
Console.Write("]");

int Method(int a)
{
    return numbers[a];
}
*/