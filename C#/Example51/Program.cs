/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д*/

using static System.Console;
using System.Linq;
Clear();

int[,] mat = GetMatrix(3, 3);

PrintMatrix(mat);

WriteLine(NewMatrix(mat));

int[,] GetMatrix(int rows, int colums)
{

    int[,] result = new int[rows, colums];


    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }


    return result;

}

int NewMatrix(int[,] matt)
{
    int sum = 0;

    for (int i = 0; i < matt.GetLength(0); i++)
    {
        for (int j = 0; j < matt.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matt[i, j];
            }
        }
    }
    return sum;

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