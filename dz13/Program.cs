// Задача 13. Напишите программу, которая выводит третью цифру заданого числа
// или сообщает, что третьей цифры нет.

int GetRandomNumber()
{
    int Random = new Random().Next();
    return Random;
}
int GetThirdDigit(int number1)
{
    while (number1 > 999)
    {
        number1 = number1 / 10;

    }
    return number1 % 10;
}
void PrintResult(int number2)
{
    Console.WriteLine("Third digit of the number -" + number2);
}
int rand = GetRandomNumber();
Console.WriteLine("Random number = " + rand);

if (rand < 100)
{
    Console.WriteLine("No third digit.");
}
else 
{
    int thirdDigit = GetThirdDigit(rand);
    PrintResult(thirdDigit);
}