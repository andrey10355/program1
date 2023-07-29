// Задача 30. Напишите программу, которая выводт массив из 8 элементов,
// заполненый нулями и единицами в случайном порядке.
// [1, 0, 1, 1, 0, 1, 0, 0]

/*int[] array = {1,2,3,4,5,6,7};
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write($"{array[i]}, ");
}
*/
int  Promt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.Readline()!);
    return num;
}
int[] Fill(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
    a[i] = new Random().Next(0, 2);
    }
    return a;
}
void PrintMass(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
    Console.Write($"{a[i]} ");
    }
}

int N = Promt("enter massiv: ");
int[] array = new int[N];
PrintMass(Fill(array));

