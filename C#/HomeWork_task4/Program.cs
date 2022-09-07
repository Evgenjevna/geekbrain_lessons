using static System.Console;
Clear();
WriteLine("Введите три числа(Используя кнопку ENTER): ");
int a = int.Parse(ReadLine());
int b = int.Parse(ReadLine());
int c = int.Parse(ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Write("max = ");
Write(max);