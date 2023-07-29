// Задача 18.
// Напишите программу, которая по заданому номеру четверти, показвает диапазон возможных координат
// точек в этой четверти (X and Y).

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

string GetResult( int number)
{
    string res = String.Empty;
    if (number < 1 || number > 4)
    {
        res = "Значение не соответсвтует условию";
    }
    else
    {
        if (number == 1)
        {
            res = "x от 0 до + бесконечности, y от 0 до + бесконечности";
        }
        else if (number == 2)
        {
            res = "x от 0 до - бесконечности, y от 0 до + бесконечности";
        }
        else if (number == 3)
        {
            res = "x от 0 до - бескончности, y от 0 до - бесконечности";
        }
        else if (number == 4)
        {
            res = "x от 0 до + бесконечности, y от 0 до + бесконечности";
        }
    }
    return res;
}

int sqr = Prompt("Введите номер четверти: ");
Console.WriteLine(GetResult(sqr));