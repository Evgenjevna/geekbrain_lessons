using static System.Console;
Clear();

WriteLine("Введите десятичное число: ");
int a = int.Parse(ReadLine());
convert (a);





void convert(int integer)
{
    if (integer == 0) { Write($"{integer}"); return; }
    else if (integer != 1) convert(integer / 2);
    Write($"{integer % 2}");
}
