﻿// Задача 13. Напишите программу, которая выводит третью цифру заданого числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет 
// 32679 -> 6

string mess = "Введите число: ";
int number1 = Prompt(mess);

int result = FindThirdNumber(number1);
   if (result == -1)
   {
    Console.WriteLine("Такой цифры нет!");
   }
   else
   {
    Console.WriteLine($"Третья цифра числа {result}");
   }


int Prompt(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    int num = Math.Abs(Converter.ToInt32(Console.Readline()));
    return num;
}

int FindThirdNumber(int num)
{
    if (num < 100)
    {
        return -1;

    }
    else
    {
        while (num >= 1000)
        {
            num = num /10;
    
        }
        int thirdNumber = num % 10;
        return thirdNumber;
    }
}
