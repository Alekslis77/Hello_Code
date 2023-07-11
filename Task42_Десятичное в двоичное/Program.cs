/*
Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10
*/
System.Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

int binary = 0;
int shift = 1;
while(value != 0)
{
    binary += value % 2 * shift;
    shift *= 10;
    value /= 2;
}

Console.Write(binary);

// void DecimalToBinary(string[] args)
// {
//     Console.Write("Введите десятичное число: ");
//     int decimalNumber = Convert.ToInt32(Console.ReadLine());

//     string binaryNumber = Convert.ToString(decimalNumber, 2);

//     Console.WriteLine("Двоичное представление: " + binaryNumber);
// }

// DecimalToBinary(new string[0]);

//через стринг

// double DecimalToBinary(int dec)
// {
//     double bin = 0;
//     int count = 0;
//     while (dec > 0)
//     {
//         bin += dec % 2 * Math.Pow(10, count);
//         dec /= 2;
//         count++;
//     }
//     return bin;
// }

// Console.WriteLine(DecimalToBinary(123));

// void DecimalToBinary(string[] args)
// {
//     Console.Write("Введите десятичное число: ");
//     int decimalNumber = Convert.ToInt32(Console.ReadLine());

//     string binaryNumber = Convert.ToString(decimalNumber, 2);

//     Console.WriteLine("Двоичное представление: " + binaryNumber);
// }

// DecimalToBinary(new string[0]);