/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using static System.Console;
using System.Linq;
Clear();

int[,] mat1 = GetMatrix1(2, 2);   //Задание размеров первой матрицы (2 строки 2 столбца)
int[,] mat2 = GetMatrix2(2, 2);   //Задание размеров второй матрицы (2 строки 2 столбца)
int[,] mat3 = GetMult(mat1, mat2);

WriteLine("Первая матрица:");
PrintMatrix(mat1);
WriteLine("Вторая матрица:");
PrintMatrix(mat2);
WriteLine("Результат умножения матриц:");
PrintMatrix(mat3);
WriteLine();

int[,] GetMatrix1(int rows, int colums)  //Генерация первой рандомной интовой матрицы числами в диапазоне от 0 до 5
{
    int[,] result = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(0, 5) + 1;
        }
    }
    return result;
}

int[,] GetMatrix2(int rows, int colums)  //Генерация второй рандомной интовой матрицы числами в диапазоне от 0 до 5
{
    int[,] result = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(0, 5) + 1;
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix) //Вывод матриц на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write(matrix[i, j] + "\x020");
        }
        WriteLine();
    }
}
int[,] GetMult(int[,] mat1, int[,] mat2) //Умножение первой матрицы на вторую
{
    var mat3 = new int[2, 2];
    for (var i = 0; i < 2; i++)
    {
        for (var j = 0; j < 2; j++)
        {
            mat3[i, j] = 0;
            for (var k = 0; k < 2; k++)
            {
                mat3[i, j] += mat1[i, k] * mat2[k, j];
            }
        }
    }
    return mat3;
}