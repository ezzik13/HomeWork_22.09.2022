// Задача 23
// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
using static System.Console;
Clear();

WriteLine("Введите число");
int Number1 = Convert.ToInt32(ReadLine()!);
int count = 1;

while (count < Number1+1)
{
    Write($"{Math.Pow(count, 3)} ");
    // count+=1;
    count++;
}