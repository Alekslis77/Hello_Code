/*
Известны два расстояния: одно в километрах, 
другое — в футах (1 фут 0,305 м). 
Какое из расстояний меньше?
*/

double EnterMetod(string textOut)
{
    Console.Write(textOut);
    double numberIn = Convert.ToDouble(Console.ReadLine());
    return numberIn;
}


Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
double distOne = EnterMetod("Введите первое расстояние в километрах: ");
Console.ForegroundColor = ConsoleColor.Green;
double distTwo = EnterMetod("Введите второе расстояние в футах: ");
Console.ForegroundColor = ConsoleColor.Red;
if (distOne*1000 < distTwo*0.305) 
{
    Console.WriteLine($"Расстояние {distOne} " +
                            $"км меньше расстояния {distTwo} фут.");
}
else
{
    Console.WriteLine($"Расстояние {distTwo} " +
                            $"фут меньше расстояния {distOne} км.");
}
Console.ResetColor();