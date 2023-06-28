/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру дня недели: ");
int numbDay = Convert.ToInt32(Console.ReadLine());

if (numbDay < 1 || numbDay > 7) Console.WriteLine
                            ("Нет такого дня недели");
else {
    Console.Write($"Является ли день {numbDay} выходным ? -> ");
    if (numbDay > 5) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
