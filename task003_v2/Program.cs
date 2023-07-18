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

void Square(int num)
{
int count = 1;
while (count <= num)
{
   if (count == num)
    Console.Write(count * count);
else
    Console.Write(count * count + " ");
    count++;
}
}



int n = GetNumber("Input number: ");
Square(n);
