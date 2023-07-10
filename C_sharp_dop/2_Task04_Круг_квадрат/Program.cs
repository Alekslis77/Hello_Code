/*
Даны радиус круга и сторона квадрата. 
У какой фигуры площадь больше?
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите радис круга r: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите длину стороны квадрата a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        const double pi = Math.PI;
        double areaCircle = pi * r * r;
        double areaSquare = a * a;

        if (areaCircle < areaSquare)
        {
            Console.WriteLine("Площадь квадрата больше площади круга");
        }
        else
        {
            Console.WriteLine("Площадь круга больше площади квадрата");
        }
    }
}