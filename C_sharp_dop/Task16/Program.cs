/*
Cоставить программу обмена значениями 
трех переменных величин а, b, c 
по двум следующим схемам: 
    а) b присвоить значение c, 
            а присвоить значение b, 
                    с присвоить значение а;
    б) b присвоить значение а, 
            с присвоить значение b, 
                    а присвоить значение с.
*/

int temp;

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());


temp = b;
int b1 = c;
int c1 = a;
int a1 = temp;

Console.WriteLine("Схема a): ");
Console.WriteLine($"Число a = {a} -> {a1}\nЧисло b = {b} -> {b1}\nЧисло c = {c} -> {c1}");

int b2 = a;
int a2 = c;
int c2 = temp;

Console.WriteLine("Схема b): ");
Console.WriteLine($"Число a = {a} -> {a2}\nЧисло b = {b} -> {b2}\nЧисло c = {c} -> {c2}");