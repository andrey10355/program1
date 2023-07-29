// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int GetRandomNumber()
{
    int randNumber = new Random().Next(100,1000);
    return randNumber;
}

int GetFirstDigit(int numA)
{
    return numA / 100;
}

int GetLastDigit(int numB)
{
    return numB % 10;
}

void PrintNumber(int numC)
{
    Console.WriteLine(numC);
}

void PrintResult(int num1, int num2)
{
    Console.WriteLine(num1 + " -> " + num2);
}

int randNumber = GetRandomNumber();
PrintNumber(randNumber);
int firstDigit = GetFirstDigit(randNumber);
PrintNumber(firstDigit);
int lastDigit = GetLastDigit(randNumber);
PrintNumber(lastDigit);
int resultNumber = (firstDigit * 10 + lastDigit);
PrintResult(randNumber, resultNumber);
