using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите числа через пробел:");
int count = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(M=>int.Parse(M)).ToArray().Where(a=>a>0).Count();
WriteLine(count);