/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

string GetQuarter(int N)
{
    string result = " ";
    if (N == 1)
    {
        result = "Диапазон точек X > 0, Y > 0";   
    }
    else if (N == 2)
    {
        result = "Диапазон точек X < 0 , Y > 0";
    }
    else if (N == 3)
    {
        result = "Диапазон точек X < 0, Y < 0";
    } 
    else if (N == 4) 
    {
        result = "Диапазон точек X > 0, Y < 0";
    }
    else if (N < 1 || N > 4)
    {
        result = "Нет такой четверти на кооординатной плоскости";
    }
    return result;
}
    
Console.WriteLine($"Введите номер четверти координатной плоскости: ");
int nQuart = Convert.ToInt32(Console.ReadLine());

string quarter = GetQuarter(nQuart);

Console.WriteLine(quarter);

/*
string QuadrantRange(int quadrant)
{
    if (quadrant == 1) return "x > 0; y > 0";
    else if (quadrant == 2) return "x < 0; y > 0";
    else if (quadrant == 3) return "x < 0; y < 0";
    else if (quadrant == 4) return "x > 0; y < 0";
    else return "invalid quadrant";
}

Console.Write("Enter a quadrant number: ");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(QuadrantRange(quarter));
*/