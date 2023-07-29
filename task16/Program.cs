// Задача 16.
// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5, 25 -> yes
// -4, 16 -> yes
// 25, 5 -> yes
// 8, 9 -> no

void CheckCondition(int numA, int numB)
{
    if (numA * numA == numB || numA % numB == 0)
    {
        Console.Write("yes");
    }
    else
    {
        Console.Write("no");
    }
}

Console.Write("Enter first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = int.Parse(Console.ReadLine());

CheckCondition(number1, number2);
