// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("Введите x точки A");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y точки A");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z точки A");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x точки B");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y точки B");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z точки B");
int zB = Convert.ToInt32(Console.ReadLine());



double result = Math.Round(Math.Sqrt((xA - xB)*(xA - xB) + (yA - yB)*(yA - yB) + (zA - zB)*(zA - zB)), 2);

Console.WriteLine(result);