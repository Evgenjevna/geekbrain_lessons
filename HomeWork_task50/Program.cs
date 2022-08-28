/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите размеры массива");
int m = Convert.ToInt32(ReadLine());
int n = Convert.ToInt32(ReadLine());
int[,] mat = GetMatrix(m, n);

PrintMatrix(mat);

WriteLine("Введите координаты числа в массиве");
int a = Convert.ToInt32(ReadLine());
int b = Convert.ToInt32(ReadLine());
if (a > m || b > n)
    WriteLine("-> такого числа в массиве нет");
else
{
    object c = mat.GetValue(a, b);
    WriteLine($"Введённым кординатам соответсвтует число {c}");
}

int[,] GetMatrix(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 100) + 1;
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write(matrix[i,j] + "\t  ");
        }
        WriteLine();
    }
}