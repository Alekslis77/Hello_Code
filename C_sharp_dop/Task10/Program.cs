/*
Известна стоимость монитора, системного блока, клавиатуры и мыши. 
Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?
*/

double monitorPrice = 25567.5;
double sysBlockPrice = 67570.7;
double keyboardPrice = 7860.3;
double mousePrice = 2560.6;
double compPrice = monitorPrice + sysBlockPrice 
                    + keyboardPrice + mousePrice;

Console.WriteLine("Введите требуемое количество компьютеров: ");
double numbComp = Convert.ToDouble(Console.ReadLine());
double result = compPrice * 3;
double result2 = numbComp * compPrice;

Console.Write($"Стоимость трех компьютеров составляет ");
Console.Write(result.ToString("F2")); // 24,80 р.
Console.WriteLine(" рублей.");
Console.Write($"Стоимость {numbComp} компьютеров составит ");
Console.Write(result2.ToString("F2"));
Console.Write(" рублей.");