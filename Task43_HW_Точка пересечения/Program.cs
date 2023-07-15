/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double EnterMetod(string textOut)
{
    Console.Write(textOut);
    double numberIn = Convert.ToDouble(Console.ReadLine());
    return numberIn;
}

void PointFind(double bOne,  double kOne, double bTwo, double kTwo)
{
    double x = (bTwo - bOne) / (kOne - kTwo);
    double y = kOne*x + bOne;
    Console.WriteLine($"b1 = {bOne}, k1  = {kOne}, b2 = {bTwo}, k2 = {kTwo} -> (x = {x}; y = {y})");
} 

PointFind(
    EnterMetod("Введите b1: "), 
    EnterMetod("Введите k1: "), 
    EnterMetod("Введите b2: "), 
    EnterMetod("Введите k2: ")
    );