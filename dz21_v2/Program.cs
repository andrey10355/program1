// Задача 21.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
//в 3D пространстве.
// A (3, 6, 8); B (2, 1, -7) -> 15,84
// A (7, -5, 0); B (1, -1, 9) -> 11,53

int Coordinata(string message) // пишем передаваемое сообщение - запрашиваем у пользователя число
{
    Console.Write(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
double Distance (int a, int b, int c, int d, int e, int f) // считываем расстояние на оси координат между двумя точками и на выходе выдаем расстояние
{
    double distance = Math.Sqrt((a - c) * (a - c) + (b - d) * (b - d) + (e - f) * (e - f));
    return distance;
}
int x1 = Coordinata("Ente the x coordinate of point 1");
int y1 = Coordinata("Ente the y coordinate of point 1");
int z1 = Coordinata("Ente the z coordinate of point 1");
int x2 = Coordinata("Ente the x coordinate of point 2");
int y2 = Coordinata("Ente the y coordinate of point 2");
int z2 = Coordinata("Ente the z coordinate of point 2");


Console.WriteLine("Distance between points: " + Distance(x1, y1, x2, y2, z1, z2));
