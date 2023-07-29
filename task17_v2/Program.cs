//Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X и Y не равно 0 и выдаёт номер четверти.
// Вариант 2.

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

string GetResult(int X, int Y)
{
    string res = String.Empty;
    if (X > 0 && Y > 0)
    {
        res = " first partition";
    }
    else if (X < 0 && Y > 0)
    {
        res = "second partition";
    }
     else if (X < 0 && Y < 0)
    {
        res = "third partition";
    }
    else if (X > 0 && Y < 0)
    {
        res = "fourth partition";
    }
    return res;
}

int x = Prompt("Enter point X: ");
int y = Prompt("Enter point Y: ");
if (x == 0 || y ==0)
{
    Console.WriteLine("Invalid data format!");
}
else
{
    Console.WriteLine(GetResult(x, y));
}