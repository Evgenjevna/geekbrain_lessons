/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


using static System.Console;
using System.Linq;
Clear();

int[,] mat = GetMatrix(6, 6);

PrintMatrix(mat);
WriteLine();
GetSumColums(mat);

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

void GetSumColums(int[,] mat)
{
    for (int i = 0; i < 6; i++)
    {
        int resault = 0;
        int summ = 0;
        for (int j = 0; j < 6; j++)
        {
            resault += mat[j,i];
            summ += mat [i,j];
        }
        WriteLine($"Среднее арифметическое элементов колонки {i+1} равно {(double)resault / 6:f1}");    //Расчёт среднего арифметического столбцов
       // WriteLine($"Среднее арифметическое элементов строки {i+1} равно {(double)summ / 6:f1}");      //Расчёт среднего арифметического строк
    }
    WriteLine();
}