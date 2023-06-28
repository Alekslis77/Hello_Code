// Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности.

Console.WriteLine("Enter a cube's side: ");
double side = Convert.ToDouble(Console.ReadLine());
double volume = Math.Pow(side, 3);
double area = Math.Pow(side, 2);
Console.WriteLine($"Volume of cube with side {side} is {volume}; Area is {area}");
