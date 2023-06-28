//С некоторого момента прошло 234 дня. 
//Сколько полных недель прошло за этот период?

Console.Clear();
Console.WriteLine("Введите количество дней: ");
int periodDay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В периоде {periodDay} дней, {periodDay / 7} полных недель.");
