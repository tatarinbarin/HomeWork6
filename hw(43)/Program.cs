// Задача 43: Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2, k2 вводит пользователь.


void PointIntersectionTwoStraight(double b1, double k1, double b2, double k2)
{

    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения двух прямых X: {x}, Y: {y}");

}

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());

PointIntersectionTwoStraight(k1, b1, k2, b2);
