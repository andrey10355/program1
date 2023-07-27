// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Promt(string message) // создаём метод для печати
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int num = Promt("Enter number1: ");
int count = 0;
for (count = 0; num > 0; count++)
{
    num = num / 10;
}
Console.WriteLine(count);
