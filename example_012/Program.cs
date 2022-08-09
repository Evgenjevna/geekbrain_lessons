using static System.Console;
Clear();
WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int numberC = (numberB % numberA);
if (numberC == 0)
{
    Write($"кратно: {numberC}");
}
else
{
    Write($"не кратно: {numberC}");
}
