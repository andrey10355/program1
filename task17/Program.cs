//Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X и Y не равно 0 и выдаёт номер четверти.


int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
void GetResult(int X, int Y)
{
    if (X > 0 && Y > 0)
    {
        Console.WriteLine("1st quater");
    }
    if (X < 0 && Y > 0)
    {
        Console.WriteLine("2st quater");
    }
    if (X < 0 && Y < 0)
    {
        Console.WriteLine("3st quater");
    }
    if (X > 0 && Y < 0)
    {
        Console.WriteLine("4st quater");
    }

}

int x = Prompt("Input point X: ");
int y = Prompt("Input point Y: ");
GetResult(x, y);

