/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

using static System.Console;
using System.Linq;
Clear();

int[,] mat = GetMatrix(6, 6);

PrintMatrix(mat);
WriteLine();
GetSort(mat);
PrintMatrix(mat);
WriteLine();

int[,] GetMatrix(int rows, int colums)
{
    int[,] result = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
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
            Write(matrix[i, j] + "\t  ");
        }
        WriteLine();
    }
}

void GetSort(int[,] mat)
{
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            for (int k = j + 1; k < 6; k++)
            {
                if (mat[i, j] < mat[i, k])
                {
                    int t = mat[i, j];
                    mat[i, j] = mat[i, k];
                    mat[i, k] = t;
                }
            }
        }
    }
}