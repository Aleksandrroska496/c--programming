
// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое сисло кводратом второго.
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int q2 = n2 * n2;

if (n1 == q2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

// Задача 2. Напишиет программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

if (n < 0)
{
    current = n;
    n = -n;
}

while (current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 3. Напишите программу, которая принимает над вход трёхзначное число и на выходе показывает последнию цифру этого числа.

Console.Write("Inrut a three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n < 1000)
{
    Console.WriteLine("Last digit of " + n + " is " + n % 10);
}
else
{
    Console.WriteLine("Uncorrect input!");
}
