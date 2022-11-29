//Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 

Console.Clear();
Console.WriteLine("Введите координату Х для точки А");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y для точки А");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z для точки А");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X для точки B");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y для точки B");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z для точки B");
double z2 = Convert.ToInt32(Console.ReadLine());

double Result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
Console.WriteLine(Result);