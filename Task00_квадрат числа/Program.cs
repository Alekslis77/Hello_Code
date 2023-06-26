/*
Напишите программу, которая навход принимает чмслоивыдает его квадрат
(чмсло умноженное на самого себя).

4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine(result);