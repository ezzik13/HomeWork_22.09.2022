// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


using static System.Console;
Clear();
Write("Введите координаты первой точки: ");
int X1=int.Parse(ReadLine()!);
int Y1=int.Parse(ReadLine()!);
Write("Введите координаты второй точки: ");
int X2=int.Parse(ReadLine()!);
int Y2=int.Parse(ReadLine()!);

WriteLine($"{Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1)):f2}");

