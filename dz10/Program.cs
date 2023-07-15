// Задача 10. Напишите программу, которая принимает на вход трёх значное число и на выходе показывает 
//вторую цифру этого числа
// 456-> 5
// 782-> 2
// 918-> 8

int SecondDigit(int number1)
{
    return number1 / 10 % 10;
}
void PrintSecondDigit(int number2)
{
    Console.WriteLine("the secong digit of your number - " + number2 +".");
}
Console.WriteLine("enter a three-digit number: ");
int number = int.Parse(Console.ReadLine());

if (number <100 || number > 999)
{
    Console.WriteLine("Its not a three digit number. Start agan.");   
}
else
{
    int secondDigit = SecondDigit(number);
    PrintSecondDigit(secondDigit);
}