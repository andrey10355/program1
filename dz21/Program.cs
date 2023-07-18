// Задача 21.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
//в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int Coordinata(string message)
{
    Console.Write(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
double Distance (int a, int b, int c, int d)
{
    double distance = Math.Sqrt((a - c) * (a - c) + (b - d) * (b - d));
    return distance;
}
int x1 = Coordinata("Ente the x coordinate of point 1");
int y1 = Coordinata("Ente the y coordinate of point 1");
int x2 = Coordinata("Ente the x coordinate of point 2");
int y2 = Coordinata("Ente the y coordinate of point 2");

Console.WriteLine("Distance between points: " + Distance(x1, y1, x2, y2));
