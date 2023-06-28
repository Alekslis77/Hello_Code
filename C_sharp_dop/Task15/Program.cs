// Составить программу обмена значениями двух переменных величин.

int temp;

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

temp = a;
a = b;
b = temp;

Console.WriteLine($"Число a = {a}");
Console.WriteLine($"Число b = {b}");