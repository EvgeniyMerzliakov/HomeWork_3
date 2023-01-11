// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.


Console.WriteLine("Введите мерность пространсва");
int N = Convert.ToInt32(Console.ReadLine());

int[] arrayA = new int [N];
int[] arrayB = new int [N];

Console.WriteLine("Введите координаты точки A, по одному числу, исходя из мерности пространства");
for (int i = 0; i < N; i++) arrayA[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B, по одному числу, исходя из мерности пространства");
for (int i = 0; i < N; i++) arrayB[i] = Convert.ToInt32(Console.ReadLine());


double Magic(int[] pointA, int[] pointB)
{
    int D = 0;
    int sum = 0;
    int N = pointA.Length;
    for (int i = 0; i < N; i++)
    {
        D = (pointA[i] - pointB[i]) * (pointA[i] - pointB[i]);
        sum = sum + D; 
    }
    double result = Math.Round(Math.Sqrt(sum), 2);
    return result;
}

Console.WriteLine(Magic(arrayA, arrayB));


// double D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); 

// double result = Math.Sqrt((xA - xB)*(xA - xB))




