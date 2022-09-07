/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.*/

using static System.Console;
Clear();
WriteLine("Введите число A");
int number1 = int.Parse(ReadLine());
WriteLine("Введите число B");
int number2 = int.Parse(ReadLine());
WriteLine($"{GetNumber(number1, number2)}");


int GetNumber (int A, int B)
{
    //if (B == 1) return A;
    if (B == 0) return 1;
    return GetNumber(A,B-1)*A;
}