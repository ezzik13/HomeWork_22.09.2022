// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
using static System.Console;
Clear();
WriteLine("ВВедите координаты первой точки - Х: ");
int x1 = Convert.ToInt32(ReadLine());
WriteLine("ВВедите координаты первой точки - Y: ");
int y1 = Convert.ToInt32(ReadLine());
WriteLine("ВВедите координаты первой точки - Z: ");
int z1 = Convert.ToInt32(ReadLine());
WriteLine("ВВедите координаты второй точки - Х: ");
int x2 = Convert.ToInt32(ReadLine());
WriteLine("ВВедите координаты второй точки - Y: ");
int y2 = Convert.ToInt32(ReadLine());
WriteLine("ВВедите координаты второй точки - Z: ");
int z2 = Convert.ToInt32(ReadLine());
Write($"Длина отрезка с координатами ({x1},{y1},{z1}),({x2},{y2},{z2}) равняется {Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)):f2}");
