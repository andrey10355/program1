// Напишите программу, которая по заданому номеру четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).

int Coordinata(string message)
{
    Console.Write(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void FindQuarter(int a)
{
    if (a < 1 || a > 4)
    Console.WriteLine("Invalid data format");
if (a == 1)
Console.Write("X = (0; +n), Y = (0; +n)");
if (a == 2)
Console.Write("X = (0; -n), Y = (0; +n)");
if (a == 3)
Console.Write("X = (0; -n), Y = (0; -n)");
if (a == 4)
Console.Write("X = (0; +n), Y = (0; -n)");
}

int quarter= Coordinata("Input number quarter: ");
FindQuarter(quarter);

