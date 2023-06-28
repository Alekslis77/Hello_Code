// Дано расстояние в сантиметрах. 
// Найти число полных метров в нем.

Console.WriteLine("Введите расстояние в сантиметрах: ");
int distanceCm = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число полных метров в расстоянии составляет: {distanceCm / 100} М");
