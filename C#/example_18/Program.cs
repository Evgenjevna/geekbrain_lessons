// вводим значения кординат X и Y - получаем номер четверти в которой находится заданная точка
using static System.Console;
Clear();

WriteLine("Введите х: ");
int numberX = Convert.ToInt32(ReadLine());
WriteLine("Введите y: ");
int numberY = Convert.ToInt32(ReadLine());
if ((numberX > 0) & (numberY > 0))
{ WriteLine("1 четверть"); }
if ((numberX > 0) & (numberY < 0))
{ WriteLine("4 четверть"); }
if ((numberX < 0) & (numberY < 0))
{ WriteLine("3 четверть"); }
if ((numberX < 0) & (numberY > 0))
{ WriteLine("2 четверть"); }