/*
Дано вещественное число а. Пользуясь только операцией умножения, получить:
а) a4 за две операции;
б) a6  за три операции;
в) a7 за четыре операции;
г) a8  за три операции;
д) a9 за четыре операции;
е) a10  за четыре операции.
*/

Console.WriteLine("Введите вещественное число a: ");
double n = Convert.ToDouble(Console.ReadLine());
double nFloat = n;
nFloat = nFloat*nFloat;
nFloat = nFloat*nFloat;

Console.WriteLine($"a4 за две операции = {nFloat}");

nFloat = n;
nFloat = nFloat*nFloat;
nFloat = nFloat*nFloat*nFloat;

Console.WriteLine($"a6 за три операции = {nFloat}");

nFloat = n;
nFloat = nFloat*nFloat;
nFloat = nFloat*nFloat*nFloat*n;

Console.WriteLine($"a7 за четыре операции = {nFloat}");

nFloat = n;
nFloat = nFloat*nFloat;
nFloat = nFloat*nFloat;
nFloat = nFloat*nFloat;

Console.WriteLine($"a8 за три операции = {nFloat}");

nFloat = n;
nFloat = nFloat*nFloat;
nFloat = nFloat*nFloat;
nFloat = nFloat*nFloat*n;

Console.WriteLine($"a9 за четыре операции = {nFloat}");

nFloat = n;
nFloat = nFloat*nFloat;
nFloat = nFloat*nFloat*n;
nFloat = nFloat*nFloat;

Console.WriteLine($"a10 за четыре операции = {nFloat}");