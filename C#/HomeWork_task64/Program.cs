/*Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N по убыванию.
M = 1; N = 5. -> ""5,4,3,2,1""
M = 4; N = 8. -> ""8,7,6,5,4""
*/

using static System.Console;
Clear();
WriteLine("Введите число M");
int M = int.Parse(ReadLine());
WriteLine("Введите число N");
int N = int.Parse(ReadLine());
WriteLine($"{GetNumbers(M, N)}");

string GetNumbers(int N, int M)
{
    return (N==M)?$"{M}":(M<N)?$"{N} "+GetNumbers(N-1,M):$"{M} " +GetNumbers(M-1,N);

}