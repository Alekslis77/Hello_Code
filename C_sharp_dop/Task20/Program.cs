/*
Дано двузначное число. 
Найти:
а) число десятков в нем;
б) число единиц в нем;
в) сумму его цифр;
г) произведение его цифр.
*/
Console.WriteLine("Введите двузначное число: ");

int doubleDigitNumber = Convert.ToInt32(Console.ReadLine());
int tens = doubleDigitNumber / 10;
Console.WriteLine($"Число десятков: {tens}");

int units = doubleDigitNumber % 10;
Console.WriteLine($"Число единиц: {units}");

int sum = tens + units;
Console.WriteLine($"Сумма цифр: {sum}");

int product = tens * units;
Console.WriteLine($"Произведение цифр: {product}");