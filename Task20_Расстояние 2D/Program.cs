/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

double Sqt(int number)
{
    double t;
    double squareRoot = number / 2;
    do {
        t = squareRoot;
        squareRoot = (t + (number / t)) / 2;
    } while ((t - squareRoot) != 0);
    return squareRoot;
}

int EnterCoord(char literPoint, char nameAxis)
{
    Console.WriteLine($"Введите координату {nameAxis} точки {literPoint}: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// Ввести координаты точек А и В;
//Console.WriteLine("Введите координаты точки А(X, Y) : ");
// int coordX1 = Convert.ToInt32(Console.ReadLine());
// int coordY1 = Convert.ToInt32(Console.ReadLine());
int coordX1 = EnterCoord('A', 'X');
int coordY1 = EnterCoord('A', 'Y');

int coordX2 = EnterCoord('B', 'X');
int coordY2 = EnterCoord('B', 'Y');

int a = coordX1 - coordX2;
int b = coordY1 - coordY2;

double disAB = Sqt(a*a + b*b);
Console.WriteLine($"Расстояние между точками A и B на плоскости = {disAB}");

//Console.WriteLine("Введите координаты точки В(X, Y) : ");
//int coordX2 = Convert.ToInt32(Console.ReadLine());
//int coordY2 = Convert.ToInt32(Console.ReadLine());
// Посчитать формулу Пифагора;

//double disAB = Math.Sqrt(((coordX1 - coordX2) * (coordX1 - coordX2)) + ((coordY1 - coordY2) * (coordY1 - coordY2)));

// Вывести результат

//Console.WriteLine($"Расстояние между точками А и В на плоскости равно = {disAB}");

// Console.WriteLine("Enter x for first point");
// int aX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y for first point");
// int aY = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter x for second point");
// int bX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y for second point");
// int bY = Convert.ToInt32(Console.ReadLine());

// int a = aY - bY;
// int b = aX - bX;

// double distance = Math.Sqrt(a * a + b * b);
// Console.WriteLine(distance);