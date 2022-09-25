// Напишите программу, которая принимает на вход пятизначное
//  число и проверяет, является ли оно палиндромом.
using static System.Console;
Clear();
WriteLine("ВВедите пятизначное число: ");
int a = Convert.ToInt32(ReadLine());
int a1=a/10000;
int a2=a/1000%10;
int a3=a/100%10;
int a4=a/10%10;
int a5=a%10;
if(a1==a5&&a2==a4)
WriteLine($"Число {a} является полиндромом!");
else
WriteLine($"Число {a} не является полиндромом!");