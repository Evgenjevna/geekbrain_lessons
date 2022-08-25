﻿/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.

0 1 2 3
1 2 3 4
2 3 4 5
*/

using static System.Console;
using System.Linq;
Clear();

int[,] mat = GetMatrix(5, 10);

PrintMatrix(mat);


int[,] GetMatrix(int rows, int colums)
{

    int[,] result = new int[rows, colums];


    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = i + j;
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
            Write($"{matrix[i, j]} ");
        }
        WriteLine();
    }
}