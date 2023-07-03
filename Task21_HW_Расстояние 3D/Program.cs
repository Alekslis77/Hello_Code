/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double Sqt(int number)
{
    double t;
    double square = number / 2;
    do {
        t = square;
        square = (t + (number / t)) / 2;
    } while ((t - square) != 0);
    return square;
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
int coordZ1 = EnterCoord('A', 'Z');

int coordX2 = EnterCoord('B', 'X');
int coordY2 = EnterCoord('B', 'Y');
int coordZ2 = EnterCoord('B', 'Z');

int a = coordX1 - coordX2;
int b = coordY1 - coordY2;
int c = coordZ1 - coordZ2;

double disAB = Sqt(a*a + b*b + c*c);
Console.WriteLine($"Расстояние между точками A и B на плоскости = {disAB}");