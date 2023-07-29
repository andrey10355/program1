// Задача 14.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> no
// 46 -> no
// 161 -> yes


void CheckCondition(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine(num + " -> yes");
    }
    else
    {
        Console.WriteLine(num + " -> no");
    }
}
Console.Write("Enter number: ");
int Number = int.Parse(Console.ReadLine());

CheckCondition(Number);