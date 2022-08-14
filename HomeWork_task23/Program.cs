//Программа принимает на вход число и выдаёт таблицу кубов от 1 до N
using static System.Console;
Clear();
WriteLine("Введте число N");
int digit=int.Parse(Console.ReadLine());
for (int i = 1; i <= digit; i++)
{
    Write($"{i * i * i} ");
}