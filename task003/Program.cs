// Задача 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1
// до N.
// 5 -> 1, 4, 9, 16, 25.
//2 -> 1, 4

int GetNumber(string message) // пишем передаваемое сообщение
{
    Console.Write(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int n = GetNumber("Input number: ");
int count = 1;
while (count <= n)
{
    Console.Write(count*count + " ");
    count++;
}