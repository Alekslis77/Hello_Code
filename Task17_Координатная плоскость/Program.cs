/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

x=34; y=-30 -> 4
x=2; y=4-> 1
x=-34; y=-30 -> 3
*/

int GetNumberOfQuarter(int argX, int argY)
{
    int result = 0;
    if (argX > 0 && argY > 0)
    {
        result = 1;   
    }
    else if ( argX < 0 && argY > 0)
    {
        result = 2;
    }
    else if (argX < 0 && argY < 0)
    {
        result = 3;
    } 
    else if (argX > 0 && argY < 0) 
    {
        result = 4;
    }
    return result;
}
    
Console.WriteLine($"Введите координату X: ");
int coordX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату Y: ");
int coordY = Convert.ToInt32(Console.ReadLine());

int quarter = GetNumberOfQuarter(coordX, coordY);



if (quarter > 0)
{Console.WriteLine($"Точка с координатами X = {coordX} и Y = {coordY},\n"
                + $"принадлежит {quarter} четверти координатной плоскости.");
}
else
{
    Console.WriteLine($"Точка с координатами X = {coordX} и Y = {coordY},\n" 
                + "находтся на пересечении плоскостей: ");
}