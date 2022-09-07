//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

using static System.Console;
Clear();
WriteLine("Введите число");
WriteLine(FunctionCount (Convert.ToInt32(ReadLine())));

int FunctionCount (int n)
{
    int result = 0;

while (n > 0)
    {
        n /= 10;
        result ++;
    }

    return result;
}