/* 
Известны количество жителей в государстве и площадь его территории. 
Определить плотность населения в этом государстве.
*/

Console.WriteLine("Введите количество жителей государства: ");
double populationSize = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите площадь территории государства: ");
double areaCountry = Convert.ToDouble(Console.ReadLine());
double populationDensity = populationSize / areaCountry;

Console.WriteLine($"Плотность населения в государстве составляет: {populationDensity} чел. / кв. км ");
 