// Задача 1. Напишите программу, которая на вход принимает два числа
//и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("input first number: ");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine("the first number is the square of the second");
}
else
{
    Console.WriteLine("the first number is not the square of the second");
}
