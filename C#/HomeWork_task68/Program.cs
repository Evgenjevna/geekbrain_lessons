/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа M и N.
M = 2, N = 3 -> A(M,N) = 29
*/

using static System.Console;
Clear();
WriteLine("Введите число M");
int M = int.Parse(ReadLine());
WriteLine("Введите число N");
int N = int.Parse(ReadLine());
WriteLine();
WriteLine($"{GetFuncAccerman(M, N)}");

int GetFuncAccerman(int M, int N) {
    if (M == 0) {
        return N + 1;
    }
    else if (N == 0 && M > 0){
        return GetFuncAccerman(M - 1, 1);
    }
    else {
        return GetFuncAccerman(M - 1, GetFuncAccerman(M, N - 1));
    }
}