// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданому номеру.
// 3 --> Среда
// 5 --> Пятница

Console.WriteLine("Enter a number from 1 to 7 ");
int day = int.Parse(Console.ReadLine());
switch (day)
{
    case 1:
    Console.WriteLine("Day of the week monday");
    break;
    case 2:
    Console.WriteLine("Day of the week tuesday");
    break;
    case 3:
    Console.WriteLine("Day of the week wednesday");
    break;
    case 4:
    Console.WriteLine("Day of the week thursday");
    break;
    case 5:
    Console.WriteLine("Day of the week friday");
    break;
    case 6:
    Console.WriteLine("Day of the week saturday");
    break;
    case 7:
    Console.WriteLine("Day ot the week sunday");
    break;
    default:
    Console.WriteLine("Day of the week not set");
    break;
}


