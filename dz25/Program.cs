// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит в степень
// число A в натуральную степень B.
// 3, 5 -> 243 (3 в степени 5)
// 2, 4 -> 16
// Вариант 1.

Console.WriteLine($"\nVariant 1. Raising a number A to a natural power B");

int Exponentiation(int numberA, int numberB)
{
    int result =1;
    for(int i=1; i <= numberB; i++)
    {
        result = result * numberA;
    }
   
    return result;
}
Console.Write("Enter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int expon = Exponentiation(numberA, numberB);
Console.WriteLine("Answer: " + expon);

