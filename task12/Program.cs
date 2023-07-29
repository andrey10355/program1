// Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. Если число 2 не крано чмслу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно.

Console.Write("Enter first number: "); //"Введите первое число:"
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number: "); //"Введите второе число:"
int b = int.Parse(Console.ReadLine());

if (b % a == 0)
{
    Console.WriteLine("multiple"); //кратно
}
else
{
    Console.WriteLine("not a multiple, remainder = " + (b % a)); //не кратно, остаток
}