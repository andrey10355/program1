// Вариант с методом
// Задача 24. Напишите программу, которая на вход принимает число (A) и выдает сумму чисел
//от 1 до A.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void GetSumNumber(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
    sum += i;
    }
Console.WriteLine($"Sum of numbers from 1 to {A} -> {sum}");
}
int A = GetNumber("Enter first number: ");
GetSumNumber(A);

int B = GetNumber("Enter second number: ");
GetSumNumber(B);

int C = GetNumber("Enter third number: ");
GetSumNumber(C);