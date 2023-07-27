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
int Razyd(int a)
{
   int count = 0;
for (count = 0; a > 0; count++)
{
    a = a / 10; 
}
return count;
}
int num = Promt("Enter number1: ");

Console.WriteLine($"Количество цифр в числе = {Razyd(num)}");
