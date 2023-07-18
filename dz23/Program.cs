// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1
// до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetNumber(string message) // пишем передаваемое сообщение
{
    Console.Write(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Square(int num) // печатаем последовательного кубов числа от 1 до N
{
int count = 1;
while (count <= num)
{
   if (count == num)
    Console.Write(count * count * count);
else
    Console.Write(count * count * count + " ");
    count++;
}
}



int n = GetNumber("Input number: "); // Запрашиваем переменную n у пользователя через фунцию GetNumber
Square(n);  //Запускаем функцию печати кубов