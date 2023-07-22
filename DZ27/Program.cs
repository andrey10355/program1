//Вариант 1.
//Задача 27. Напишите программу, которая принимает на вход число и выдает
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine($"\n Return the sum of the digits");
Console.Write("Enter number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int SumNumber (int numberA)
{
    int counter = Convert.ToString(numberA).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberA - numberA % 10;
        result = result + (numberA - advance);
        numberA = numberA / 10;
    }
    return result;
}
int sum = SumNumber(numberA);
Console.WriteLine("the sum of the digits in a number:  " + sum);
