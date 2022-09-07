/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

using static System.Console;
Clear();
WriteLine("Введите число M");
int M = int.Parse(ReadLine());
WriteLine("Введите число N");
int N = int.Parse(ReadLine());
WriteLine();
WriteLine($"Сумма чисел от M до N = {GetNumbers(M, N)}");
WriteLine();

int GetNumbers(int N, int M)
{
    if (N==M) return N; 
    if (N<M) return N + GetNumbers(N+1,M);
    else return M + GetNumbers(M+1,N);

}