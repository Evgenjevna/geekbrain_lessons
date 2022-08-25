/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.*/

using static System.Console;
using System.Linq;
Clear();

int[,] mat = GetMatrix(6, 6);

PrintMatrix(mat);
NewMatrix(mat);

WriteLine();

PrintMatrix(mat);
WriteLine();

int[,] GetMatrix(int rows, int colums) 
{
    int[,] result = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(-10, -2);
        }    
    }
    return result;
}

void NewMatrix(int[,] matt)
{
   for (int i = 2; i < matt.GetLength(0); i++)
    {
        for (int j = 2; j < matt.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            {
                matt[i,j] *= matt[i,j];
            }
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i,j]} ");
        }
    WriteLine();
    }
}
