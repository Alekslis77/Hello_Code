/* 
Известна стоимость 1 кг конфет, печенья и яблок. 
Найти стоимость всей покупки, если купили 
x кг конфет, у кг печенья и z кг яблок.
*/
double candyPrice = 103.5;
double cookiesPrice = 70.7;
double applesPrice = 90.3;

Console.WriteLine("Введите, сколько купили килограммов конфет: ");
double candyWeight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите, сколько купили килограммов печенья: ");
double cookiesWeight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите, сколько купили килограммов яблок: ");
double applesWeight = Convert.ToDouble(Console.ReadLine());

double purchasePrice = candyWeight * candyPrice 
        + cookiesWeight * cookiesPrice + applesWeight * applesPrice;

Console.Write($"Стоимость всей покупки составляет {purchasePrice} рублей.");
