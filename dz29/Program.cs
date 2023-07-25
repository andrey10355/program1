// Задача 29. Напишите программу, которая задаёт массив и 8 элементов и выводит на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine($"\n ");
Console.WriteLine("Enter a series of numbers separated by a comma: ");
string? seriosOfNumbers = Console.ReadLine();

seriosOfNumbers = seriosOfNumbers + ",";

string RemovingSpace (string series)
{
    string seriesNew = "";
    for ( int i = 0; i < seriosOfNumbers.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}

void CheckNumber2 (int series)
{
    if (series == '0'||series == '1'||series == '2'||series == '3'||series == '4'
    ||series == '5'||series == '6'||series == '7'||series == '8'||series == '9'
    ||series == ','||series == '-')
    {
    }
        else
        {
            Console.WriteLine($"");
        }
    }

int ArrayOfNumbers(string seriesNew)
{
    int [] arrayOfNumbers = new int [1];
    int j = 0;
    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = " ";
        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            CheckNumber2(seriesNew[i]);
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
        if (i < seriesNew.Length-1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray(); 
        }
        j++;
    }
    return arrayOfNumbers;
}
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while(index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            console.Write(", ");
        }
    }
    Console.Write("]");
} 
string seriesNew = RemovingSpace(seriosOfNumbers);
int [] array0fNumbers = ArrayOfNumbers(seriesNew);
PrintArray(array0fNumbers);