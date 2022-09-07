/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.*/

using static System.Console;
Clear();
WriteLine("Введите число N");
int number = int.Parse(ReadLine());
WriteLine($"{GetSumOfDigits(number)}");


int GetSumOfDigits (int n)
{
    if (n == 0) return 0;
    return GetSumOfDigits(n / 10) + n % 10;
}