/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


using static System.Console;
using System.Linq;
Clear();

int[,] mat = GetMatrix(5, 6);   //Задание размеров матрицы (двумерного массива) 5 строк 6 столбцов

PrintMatrix(mat);
WriteLine();
GetSumColums(mat);

int[,] GetMatrix(int rows, int colums)  //Генерация рандомной интовой матрицы числами от 0 до 100
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

void PrintMatrix(int[,] matrix) //Вывод матрицы на экран
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

void GetSumColums(int[,] mat)   //Расчёт суммы элементов строк
{
    int sum = int.MaxValue;
    int index = 0;

    for (int i = 0; i < 5; i++)
    {
        int temp = 0;
        for (int j = 0; j < 6; j++)
        {
            temp += mat[i, j];
        }
        if (temp < sum) //Определение строки с наименьшей суммой элементов
        {
            sum = temp;
            index = i;
        }

       WriteLine($"Сумма элементов строки {i + 1} равно {temp}");    //Вывод в консоль суммы каждой строки
    }
    WriteLine();
    WriteLine($"Наименьшая сумма элементов {+sum} в строке {index + 1} ");  //Вывод в косноль номера строки с наименьшей суммой элементов
    WriteLine();
}