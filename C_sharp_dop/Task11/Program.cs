/*
Возраст Тани — X лет, а возраст Мити — Y лет. 
Найти их средний возраст, а также определить, 
на сколько отличается возраст каждого ребенка от среднего значения.
*/

Console.WriteLine("Введите возраст девочки: ");
double girl = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите возраст мальчика: ");
double man = Convert.ToDouble(Console.ReadLine());

double average = (man + girl) / 2;

Console.WriteLine($"Средний возраст составляет {average}");

double difMan = Math.Abs(average - man);
double difGirl = Math.Abs(average - girl);

Console.WriteLine($"Отклонение от среднего возраста:\n" +
                    $"для мальчика - {difMan} года(лет)\n" + 
                    $"для девочки - {difGirl} года(лет)");