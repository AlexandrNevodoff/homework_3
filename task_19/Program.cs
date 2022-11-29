// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите пятизначое число:");

string num = Console.ReadLine();


if (num.Length > 5 || num.Length <5) Console.WriteLine ("Число не пятизначное");

else 
{
    if (num[0]==num[4] || num[1]==num[3])
    {
        Console.WriteLine($"{num} - палиндром.");
    }
    else Console.WriteLine($"{num} - не палиндром.");
}