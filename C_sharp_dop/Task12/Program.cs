/*
Два автомобиля едут навстречу друг другу 
с постоянными скоростями V1 и  V2 км/час. 
Определить, через какое время автомобили встретятся, 
если расстояние между ними было S км.
*/

Console.WriteLine("Введите скорость первого автомобиля V1: ");
double speedCar1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите скорость второго автомобиля V2: ");
double speedCar2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите расстояние между автомобилями S: ");
double distance = Convert.ToDouble(Console.ReadLine());

double meetingTime = distance / (speedCar1 + speedCar2);

Console.WriteLine($"Автомобили встретятся через: {meetingTime} час.");