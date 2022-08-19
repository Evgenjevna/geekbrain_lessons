/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

using static System.Console;
Clear();
Write("Введите число: ");
int A = int.Parse(ReadLine());
int rais = GetSum(A);
WriteLine($"Сумма цифр в числе {A} = {rais}");

int GetSum(int B){
    int result = 0;
    while (B != 0)
    {
        result += B % 10;
        B /= 10;
    }
    return result;
}