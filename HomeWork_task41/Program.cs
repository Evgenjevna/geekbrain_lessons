/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите числа через пробел:");
int count = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(M=>int.Parse(M)).ToArray().Where(a=>a>0).Count();
WriteLine(count);