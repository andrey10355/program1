// Домашнее задание. Задача 36.
// Задайте одномерный массив, заполненый случайными числами. Найдите сумму элементов
// состоящих из нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] ->0

Console.WriteLine("Enter the size of the array"); //"Введите размер массива"
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Here is our array: "); //"Вот наш массив"
PrintArray(numbers);
int sum = 0;

for (int a = 0; a < numbers.Length; a+=2)
    sum = sum + numbers[a];

    Console.WriteLine($"Total {numbers.Length} numbers, sum of elements in odd positions  = {sum}"); //сумма элементов на нечётных позициях 

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,10);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}